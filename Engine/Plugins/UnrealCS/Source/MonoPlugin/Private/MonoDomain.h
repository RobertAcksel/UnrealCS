#pragma once

#if WITH_MONO

#include <mono/metadata/object.h>
#include "Tickable.h"

class FMonoDomain : public FTickableGameObject
{
public:
	FMonoDomain();
	~FMonoDomain();

	MonoDomain* GetDomain() const { return Domain; }
	MonoImage* GetImage()const { return Image; }

	//Full Hot Reload
	void HotReload();

	//called by HotReload
	void NativeHotReload();

	static FMonoDomain* Get(){ return Instance; }

	//Open an .Net dll file
	MonoAssembly* OpenMonoAssembly(MonoDomain* domain,const FString& AssemblyName) const;

	//Create an C# object by type name
	MonoObject* CreateInstance(const FString& TypeName) const;
	//Create an c# array by type name and length
	MonoObject* CreateArray(const FString& TypeName,int32 len) const;
	bool AddTickableObject(MonoObject* obj);
	bool RemoveTickableObject(MonoObject* obj);

	//override FTickableGameObject-------------------------------------
	virtual bool IsTickableWhenPaused() const override
	{
		return true;
	}
	virtual bool IsTickableInEditor() const override
	{
		return true;
	}
	virtual void Tick(float DeltaTime) override;
	virtual bool IsTickable() const override {
		return true;
	}
	virtual TStatId GetStatId() const override { RETURN_QUICK_DECLARE_CYCLE_STAT(FMonoDomain, STATGROUP_Tickables); }
	//end override FTickableGameObject-------------------------------------

	//Send command to MainDoman.dll
	void SendCommand(const FString& cmd) const;
	
#if WITH_EDITOR
	//When open the project for the first time, install the necessary files to the project folder
	static void InstallTemplatesToGameDir();

    void OnBeginPIE(const bool bIsSimulating);
	void OnEndPIE(const bool bIsSimulating);
	void OnPausePIE(const bool bIsSimulating);
#endif

#if WITH_MONO_HOTRELOAD
	DECLARE_MULTICAST_DELEGATE(FOnHotReload);
	FOnHotReload eventBeginHotReload;
	FOnHotReload eventEndHotReload;
	bool NeedHotReload = false;
    bool NeedCompleteReload = false;
	MonoDomain* CreateGameDomain() const;
#endif

private:
	//Init mono runtime
	void Init();
	FString GameAssemblyDirectory;
	FString EngineAssemblyDirectory;
	FString RuntimeAssemblyDirectory;

	bool SetupMono();
	void ShutDownMono();
    bool UpdateMainDomain();

    //GameDomain
	MonoDomain* Domain;

	//Game Image
	MonoImage* Image;
	MonoAssembly* Assembly;

	//Engine Image
	MonoImage* EngineImage;
	MonoAssembly* EngineAssembly;
	MonoMethod* methodCreateInstance;
	MonoMethod* methodCreateArray;

	//MainDomain
	MonoDomain* MainDomain;
	MonoImage* MainImage;
	MonoObject* mainObject;
	uint32 mainObjectHandle;
	//MonoClassField* Field_NeedHotReload;

	static FMonoDomain* Instance;
};

namespace Mono
{
	void LoadMonoDLL();
	void UnloadMonoDLL();
}

#endif

