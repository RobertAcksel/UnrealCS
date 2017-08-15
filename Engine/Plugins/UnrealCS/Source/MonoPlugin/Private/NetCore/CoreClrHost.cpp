#include "CoreClrHost.h"

#include <string>
#include <stdio.h>
#include "mscoree.h"	// Generated from mscoree.idl
#include <filesystem>
#include "Paths.h"

#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#pragma warning(disable:4996) //_CRT_SECURE_NO_WARNINGS
#endif

// The host must be able to find CoreCLR.dll to start the runtime.
// This string is used as a common, known location for a centrally installed CoreCLR.dll on Windows.
// If your customers will have the CoreCLR.dll installed elsewhere, this will, of course, need modified.
// Some hosts will carry the runtime and Framework with them locally so that necessary files like CoreCLR.dll 
// are easy to find and known to be good versions. Other hosts may expect that the apps they run will include
// CoreCLR.dll next to them. Still others may rely on an environment variable being set to indicate where
// the library can be found. In the end, every host will have its own heuristics for finding the core runtime
// library, but it must always be findable in order to start the CLR.
static auto const coreCLRInstallDirectory = L"%programfiles%\\dotnet\\shared\\Microsoft.NETCore.App\\1.1.2";

// Main clr library to load
// Note that on Linux and Mac platforms, this library will
// be called libcoreclr.so or libcoreclr.dylib, respectively
static auto const coreCLRDll = L"coreclr.dll";

// Helper method to check for CoreCLR.dll in a given path and load it, if possible
// Check for CoreCLR.dll in a given path and load it, if possible
auto LoadCoreCLR(const std::wstring directoryPath)
{
    auto coreDllPath = directoryPath + L"/" + coreCLRDll;
    // <Snippet2>
    auto ret = LoadLibraryExW(coreDllPath.c_str(), nullptr, 0);
    // </Snippet2>
    return ret;
}


// Function pointer type to be used if this sample is modified to use CreateDelegate to
// call into a static managed method (with signature void (string[])). This would be
// an alternative to using the ICLRRuntimeHost2::ExecuteAssembly helper function which
// loads and executes a managed assembly's entry point directly.
typedef void (STDMETHODCALLTYPE MainMethodFp)(wchar_t ** args);

// One large main method to keep this sample streamlined.
// 
// This function demonstrates how to start the .NET Core runtime,
// create an AppDomain, and execute managed code.
//
// It is meant as an educational sample, so not all error paths are checked,
// cross-platform functionality is not yet implemented, and some design
// decisions have been made to emphasize readability over efficiency.
int wmain(int argc, wchar_t* argv[])
{
}

FCoreClrHost::FCoreClrHost() {    
    Init();
    Start();
}

FCoreClrHost::~FCoreClrHost() {
    Shutdown();
}

bool FCoreClrHost::Init() { return true; }

bool FCoreClrHost::Start() {
    printf("Sample CoreCLR Host\n\n");
    auto const unrealCSContentFolderName = TEXT("Scripts");

    auto EngineAssemblyDirectory = FPaths::Combine(*FPaths::GameDir(), TEXT("Content"), unrealCSContentFolderName, TEXT("EngineAssemblies"));
    auto startAssembly = FPaths::ConvertRelativePathToFull(FPaths::Combine(EngineAssemblyDirectory, TEXT("MainDomain.dll")));

    // The managed application to run should be the first command-line parameter.
    // Subsequent command line parameters will be passed to the managed app later in this host.
    auto targetApp = std::wstring(*startAssembly);

    // Also note the directory the target app is in, as it will be referenced later.
    auto targetAppPath = std::wstring(std::experimental::filesystem::path(targetApp).remove_filename().c_str());

    auto coreRoot = targetAppPath;

    auto coreCLRModule = LoadCoreCLR(coreRoot);

    // If CoreCLR.dll wasn't in %CORE_ROOT% or next to the app, 
    // look in the common 1.1.0 install directory
    if (!coreCLRModule)
    {
        wchar_t coreRootx[MAX_PATH];
        ::ExpandEnvironmentStringsW(coreCLRInstallDirectory, coreRootx, MAX_PATH);
        coreCLRModule = LoadCoreCLR(coreRoot = coreRootx);
    }

    if (!coreCLRModule)
    {
        printf("ERROR - CoreCLR.dll could not be found");
        return false;
    }
    wprintf(L"CoreCLR loaded from %s\n", coreRoot.c_str());


    //
    // STEP 3: Get ICLRRuntimeHost2 instance
    //

    // <Snippet3>
    ICLRRuntimeHost2* runtimeHost;
    FnGetCLRRuntimeHost pfnGetCLRRuntimeHost = (FnGetCLRRuntimeHost)::GetProcAddress(coreCLRModule, "GetCLRRuntimeHost");

    if (!pfnGetCLRRuntimeHost)
    {
        printf("ERROR - GetCLRRuntimeHost not found");
        return false;
    }

    // Get the hosting interface
    auto hr = pfnGetCLRRuntimeHost(IID_ICLRRuntimeHost2, (IUnknown**)&runtimeHost);
    // </Snippet3>

    if (FAILED(hr))
    {
//        printf("ERROR - Failed to get ICLRRuntimeHost2 instance.\nError code:%x\n", hr);
        return false;
    }

    //
    // STEP 4: Set desired startup flags and start the CLR
    //

    // <Snippet4>
    hr = runtimeHost->SetStartupFlags(
        // These startup flags control runtime-wide behaviors.
        // A complete list of STARTUP_FLAGS can be found in mscoree.h,
        // but some of the more common ones are listed below.
        static_cast<STARTUP_FLAGS>(
            // STARTUP_FLAGS::STARTUP_SERVER_GC |								// Use server GC
            // STARTUP_FLAGS::STARTUP_LOADER_OPTIMIZATION_MULTI_DOMAIN |		// Maximize domain-neutral loading
            // STARTUP_FLAGS::STARTUP_LOADER_OPTIMIZATION_MULTI_DOMAIN_HOST |	// Domain-neutral loading for strongly-named assemblies
            STARTUP_FLAGS::STARTUP_CONCURRENT_GC |						// Use concurrent GC
            STARTUP_FLAGS::STARTUP_SINGLE_APPDOMAIN |					// All code executes in the default AppDomain 
                                                                        // (required to use the runtimeHost->ExecuteAssembly helper function)
            STARTUP_FLAGS::STARTUP_LOADER_OPTIMIZATION_SINGLE_DOMAIN	// Prevents domain-neutral loading
            )
    );
    // </Snippet4>

    if (FAILED(hr))
    {
//        printf("ERROR - Failed to set startup flags.\nError code:%x\n", hr);
        return false;
    }

    // Starting the runtime will initialize the JIT, GC, loader, etc.
    hr = runtimeHost->Start();
    if (FAILED(hr))
    {
//        printf("ERROR - Failed to start the runtime.\nError code:%x\n", hr);
        return false;
    }
    printf("Runtime started\b");


    //
    // STEP 5: Prepare properties for the AppDomain we will create
    //

    // Flags
    // <Snippet5>
    auto appDomainFlags =
        // APPDOMAIN_FORCE_TRIVIAL_WAIT_OPERATIONS |		// Do not pump messages during wait
        // APPDOMAIN_SECURITY_SANDBOXED |					// Causes assemblies not from the TPA list to be loaded as partially trusted
        APPDOMAIN_ENABLE_PLATFORM_SPECIFIC_APPS |			// Enable platform-specific assemblies to run
        APPDOMAIN_ENABLE_PINVOKE_AND_CLASSIC_COMINTEROP |	// Allow PInvoking from non-TPA assemblies
        APPDOMAIN_DISABLE_TRANSPARENCY_ENFORCEMENT;			// Entirely disables transparency checks 
                                                            // </Snippet5>

                                                            // <Snippet6>
                                                            // TRUSTED_PLATFORM_ASSEMBLIES
                                                            // "Trusted Platform Assemblies" are prioritized by the loader and always loaded with full trust.
                                                            // A common pattern is to include any assemblies next to CoreCLR.dll as platform assemblies.
                                                            // More sophisticated hosts may also include their own Framework extensions (such as AppDomain managers)
                                                            // in this list.
    std::wstring trustedPlatformAssemblies;

    // Extensions to probe for when finding TPA list files
    wchar_t *tpaExtensions[] = {
        L"*.dll",
        L"*.exe",
        L"*.winmd"
    };

    // Probe next to CoreCLR.dll for any files matching the extensions from tpaExtensions and
    // add them to the TPA list. In a real host, this would likely be extracted into a separate function
    // and perhaps also run on other directories of interest.
    for (int i = 0; i < _countof(tpaExtensions); i++)
    {
        // Construct the file name search pattern
        auto searchPath = coreRoot + L"/" + tpaExtensions[i];

        // Find files matching the search pattern
        WIN32_FIND_DATAW findData;
        auto fileHandle = FindFirstFileW(searchPath.c_str(), &findData);

        if (fileHandle != INVALID_HANDLE_VALUE)
        {
            do
            {
                // Construct the full path of the trusted assembly
                auto pathToAdd = coreRoot + L"/" + findData.cFileName;

                // Add the assembly to the list and delimited with a semi-colon
                trustedPlatformAssemblies += pathToAdd + L";";

                // Note that the CLR does not guarantee which assembly will be loaded if an assembly
                // is in the TPA list multiple times (perhaps from different paths or perhaps with different NI/NI.dll
                // extensions. Therefore, a real host should probably add items to the list in priority order and only
                // add a file if it's not already present on the list.
                //
                // For this simple sample, though, and because we're only loading TPA assemblies from a single path,
                // we can ignore that complication.
            } while (FindNextFileW(fileHandle, &findData));
            FindClose(fileHandle);
        }
    }

    // APP_PATHS
    // App paths are directories to probe in for assemblies which are not one of the well-known Framework assemblies
    // included in the TPA list.
    //
    // For this simple sample, we just include the directory the target application is in.
    // More complex hosts may want to also check the current working directory or other
    // locations known to contain application assets.
    // Just use the targetApp provided by the user and remove the file name
    auto appPaths = targetAppPath;

    // APP_NI_PATHS
    // App (NI) paths are the paths that will be probed for native images not found on the TPA list. 
    // It will typically be similar to the app paths.
    // For this sample, we probe next to the app and in a hypothetical directory of the same name with 'NI' suffixed to the end.
    auto appNiPaths = targetAppPath + L";" + targetAppPath + L"NI";

    // NATIVE_DLL_SEARCH_DIRECTORIES
    // Native dll search directories are paths that the runtime will probe for native DLLs called via PInvoke
    auto nativeDllSearchDirectories = appPaths + L";" + coreRoot;

    auto GameAssemblyDirectory = FPaths::ConvertRelativePathToFull(FPaths::Combine(*FPaths::GameDir(), TEXT("Content"), unrealCSContentFolderName, TEXT("GameAssemblies")));
    auto RuntimeAssemblyDirectory = FPaths::ConvertRelativePathToFull(FPaths::Combine(*FPaths::GameDir(), TEXT("Content"), unrealCSContentFolderName, TEXT("framework")));
    // PLATFORM_RESOURCE_ROOTS
    // Platform resource roots are paths to probe in for resource assemblies (in culture-specific sub-directories)
    auto platformResourceRoots = std::wstring(appPaths) + L";";
    platformResourceRoots += targetAppPath + L";";
    platformResourceRoots += std::wstring(*GameAssemblyDirectory) + L";";
    platformResourceRoots += std::wstring(*RuntimeAssemblyDirectory) + L";";

    // AppDomainCompatSwitch
    // Specifies compatibility behavior for the app domain. This indicates which compatibility
    // quirks to apply if an assembly doesn't have an explicit Target Framework Moniker. If a TFM is
    // present on an assembly, the runtime will always attempt to use quirks appropriate to the version
    // of the TFM.
    // 
    // Typically the latest behavior is desired, but some hosts may want to default to older Silverlight
    // or Windows Phone behaviors for compatibility reasons.
    auto appDomainCompatSwitch = L"UseLatestBehaviorWhenTFMNotSpecified";
    // </Snippet6>


    //
    // STEP 6: Create the AppDomain
    //

    // <Snippet7>
    DWORD domainId;

    // Setup key/value pairs for AppDomain  properties
    wchar_t const * propertyKeys[] = {
        L"TRUSTED_PLATFORM_ASSEMBLIES",
        L"APP_PATHS",
        L"APP_NI_PATHS",
        L"NATIVE_DLL_SEARCH_DIRECTORIES",
        L"PLATFORM_RESOURCE_ROOTS",
        L"AppDomainCompatSwitch"
    };

    // Property values which were constructed in step 5
    wchar_t const * propertyValues[] = {
        trustedPlatformAssemblies.c_str(),
        appPaths.c_str(),
        appNiPaths.c_str(),
        nativeDllSearchDirectories.c_str(),
        platformResourceRoots.c_str(),
        appDomainCompatSwitch
    };

    // Create the AppDomain
    hr = runtimeHost->CreateAppDomainWithManager(
        L"Sample Host AppDomain",		// Friendly AD name
        appDomainFlags,
        nullptr,							// Optional AppDomain manager assembly name
        nullptr,							// Optional AppDomain manager type (including namespace)
        sizeof(propertyKeys) / sizeof(wchar_t*),
        propertyKeys,
        propertyValues,
        &domainId);
    // </Snippet7>

    if (FAILED(hr))
    {
//        printf("ERROR - Failed to create AppDomain.\nError code:%x\n", hr);
        return false;
    }
    printf("AppDomain %d created\n\n", (int)domainId);


    //
    // STEP 7: Run managed code
    //

    // ExecuteAssembly will load a managed assembly and execute its entry point.
    wprintf(L"Executing %s...\n\n", targetApp.c_str());

    wchar_t const * argv[]=  {
        targetApp.c_str(),
    };

    // <Snippet8>
    DWORD exitCode = -1;
    hr = runtimeHost->ExecuteAssembly(domainId, targetApp.c_str(), 1, (&argv[0]), &exitCode);
    // </Snippet8>

    if (FAILED(hr))
    {
//        wprintf(L"ERROR - Failed to execute %s.\nError code:%x\n", targetApp.c_str(), hr);
        return false;
    }

    // Alternatively, to start managed code execution with a method other than an assembly's entrypoint,
    // runtimeHost->CreateDelegate can be used to create a pointer to an arbitrary static managed method
    // which can then be executed directly or via runtimeHost->ExecuteInAppDomain.
    //
    //  void *pfnDelegate = NULL;
    //  hr = runtimeHost->CreateDelegate(
    //	  domainId,
    //	  L"HW, Version=1.0.0.0, Culture=neutral",	// Target managed assembly
    //	  L"ConsoleApplication.Program",				// Target managed type
    //	  L"Main",									// Target entry point (static method)
    //	  (INT_PTR*)&pfnDelegate);
    //  if (FAILED(hr))
    //  {
    //	  printf("ERROR - Failed to create delegate.\nError code:%x\n", hr);
    //	  return -1;
    //  }
    //  ((MainMethodFp*)pfnDelegate)(NULL);



    //
    // STEP 8: Clean up
    //

    // <Snippet9>
    runtimeHost->UnloadAppDomain(domainId, true /* Wait until unload complete */);
    runtimeHost->Stop();
    runtimeHost->Release();
    // </Snippet9>

    printf("\nDone\n");

    return true;
}
