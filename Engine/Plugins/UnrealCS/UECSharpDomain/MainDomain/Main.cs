using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;
using UnrealEngine;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace MainDomain{
    public class Main{
        private static Main instance;

        private readonly bool withEidtor;
        private readonly string gameName;
        private readonly string pluginBaseDir;
        private readonly string engineAssembliesDir;
        private readonly string gameAssembliesDir;
        private string shadowCopyDirectory;

        private AppDomain gameDomain;
        private System.IO.FileSystemWatcher fsw;

        public Main(string gameName, string pluginBaseDir, string engineAssembliesDir, string gameAssembliesDir, string shadowCopyDirectory, int withEidtor){
            this.withEidtor = withEidtor != 0;
            this.gameName = gameName;
            this.pluginBaseDir = pluginBaseDir;
            this.engineAssembliesDir = engineAssembliesDir;
            this.gameAssembliesDir = gameAssembliesDir;
            this.shadowCopyDirectory = shadowCopyDirectory;

            if (this.withEidtor)
                CreateFileWatcher();
        }

        private void CreateFileWatcher(){
            //Open the file monitoring service
            fsw = new FileSystemWatcher(gameAssembliesDir){
                Filter = "*.dll",
                NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.FileName
            };
            //fsw.Changed += Fsw_Changed;
            fsw.Created += Fsw_Created;
            //fsw.Deleted += Fsw_Deleted;
            fsw.Error += Fsw_Error;
            //fsw.Renamed += Fsw_Renamed;
            fsw.IncludeSubdirectories = false;
            fsw.InternalBufferSize = 10240;
            fsw.EnableRaisingEvents = true;

            UnrealEngine.UObject.LogInfo("Start file hot reload listens at '" + gameAssembliesDir + "Game.dll'");
        }

        private void Fsw_Renamed(object sender, RenamedEventArgs e){
            UnrealEngine.UObject.LogInfo("Fsw_Renamed:" + e.OldName + " NewName:" + e.Name);
        }

        private void Fsw_Error(object sender, ErrorEventArgs e){
            UnrealEngine.UObject.LogInfo("Fsw_Error:" + e.ToString());
        }

        private void Fsw_Deleted(object sender, FileSystemEventArgs e){
            UnrealEngine.UObject.LogInfo("Fsw_Deleted:" + e.Name);
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e){
            UnrealEngine.UObject.LogInfo("Fsw_Created:" + e.Name);
            NativeReload();
        }

        private void Fsw_Changed(object sender, FileSystemEventArgs e){
            UnrealEngine.UObject.LogInfo("Fsw_Changed:" + e.Name);
            NativeReload();
        }

        public void OnCommand(string cmd){
            switch (cmd){
                case "OpenProject":
                    OpenProject();
                    break;
                case "AOT":
                    AOT();
                    break;
                default:
                    break;
            }
        }

        private void CopyFolder(string Dest, string Src){
            if (!(Dest.EndsWith("\\") || Dest.EndsWith("/")))
                Dest += "/";
            if (!(Src.EndsWith("\\") || Src.EndsWith("/")))
                Src += "/";
            if (!Directory.Exists(Dest))
                Directory.CreateDirectory(Dest);

            // subfolders
            foreach (var sub in Directory.GetDirectories(Src, "*", SearchOption.TopDirectoryOnly)){
                var name = Path.GetFileName(sub);
                CopyFolder(Path.Combine(Dest, name), Path.Combine(Src, name));
            }

            // files
            foreach (var file in Directory.GetFiles(Src, "*", SearchOption.TopDirectoryOnly)){
                var name = Path.GetFileName(file);
                File.Copy(Path.Combine(Src, name), Path.Combine(Dest, name), true);
            }
        }

        private void OpenProject(){
            var sourceDir = Path.Combine(pluginBaseDir, "Project");
            var destinationDir = Path.Combine(FPaths.GameDir(), "Project");
            var solutionPath = Path.Combine(FPaths.GameDir(), "Project", "Script.sln");
            //Check the script works
            if (!Directory.Exists(destinationDir)){
                //Copy the script template to the project directory
                UObject.LogInfo($"Copy script project template from '{sourceDir}' to '{destinationDir}'");
                CopyFolder(destinationDir, sourceDir);

                ////Rename the static library, otherwise the package will fail
                //string MonoHelperFilePathName = Path.Combine(FPaths.GamePluginsDir(), "Mono", "Binaries", "Win64", "UE4-MonoHelper.lib");
                //if(File.Exists(MonoHelperFilePathName))
                //{
                //    File.Move(MonoHelperFilePathName, Path.Combine(FPaths.GamePluginsDir(), "Mono", "Binaries", "Win64", gameName + "-MonoHelper.lib"));
                //}
                //else
                //{
                //    UObject.LogWarning("File Not Found:"+ MonoHelperFilePathName);
                //}
                //string MonoPluginFilePathName = Path.Combine(FPaths.GamePluginsDir(), "Mono", "Binaries", "Win64", "UE4-MonoPlugin.lib");
                //if (File.Exists(MonoPluginFilePathName))
                //{
                //    File.Move(MonoPluginFilePathName, Path.Combine(FPaths.GamePluginsDir(), "Mono", "Binaries", "Win64", gameName + "-MonoPlugin.lib"));
                //}
                //else
                //{
                //    UObject.LogWarning("File Not Found:" + MonoPluginFilePathName);
                //}
            }

            if (UGameplayStatics.GetPlatformName() == "Windows"){
                var installDir = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\devenv.exe",
                    null, "").ToString();
                if (string.IsNullOrEmpty(installDir)){
                    UObject.LogWarning("Can't find devenv.exe");
                    return;
                }
                Process.Start(installDir, solutionPath);
            } else{
                //No tool to display item location
                UObject.LogWarning("C# script solution file located at " + solutionPath);
            }
        }

        private List<string> aot_filename_list = null;

        private void AOT(){
            UObject.LogInfo("AOT Start");

            aot_filename_list = new List<string>();
            aot_filename_list.Clear();

            var last_work_dir = System.Environment.CurrentDirectory;
            try{
                var isWindows = UGameplayStatics.GetPlatformName() == "Windows";
                var isMac = UGameplayStatics.GetPlatformName() == "Mac";

                if (!isWindows && !isMac)
                    return;

                //Traverse the directory, aot each file
                var MAC_AOT_MONO_PATH = Path.GetFullPath(isWindows ? Path.Combine(pluginBaseDir, "mono_aot", "aot_host_windows_target_armv7", "bin") : Path.Combine(pluginBaseDir, "mono_aot", "aot_host_mac_target_armv7", "bin"));

                var aot_target = "armv7";
                var mscorlib_path = Path.GetFullPath(Path.Combine(pluginBaseDir, "mono_aot", "pre_aot_files", aot_target));

                var ios_predefine_header_file_pathname = Path.GetFullPath(Path.Combine(pluginBaseDir, "Source", "MonoPlugin", "Private", "ios_predefine.h"));
                var ios_private_path = Path.GetFullPath(Path.Combine(pluginBaseDir, "Source", "MonoPlugin", "Private", "IOS"));

                var outpath = Path.GetFullPath(Path.Combine(pluginBaseDir, "AOT"));
                var temppath = Path.Combine(outpath, "Temp");

                if (Directory.Exists(outpath))
                    Directory.Delete(outpath, true);
                if (Directory.Exists(temppath))
                    Directory.Delete(temppath, true);

                Directory.CreateDirectory(outpath);
                Directory.CreateDirectory(temppath);

                //Copy all dll to temp folder
                {
                    var dllPath = new List<string>{
                        engineAssembliesDir,
                        gameAssembliesDir,
                        Path.Combine(FPaths.GameDir(), "Content", "Scripts", "framework")
                    };
                    foreach (var dir in dllPath){
                        var files = Directory.GetFiles(dir, "*.dll", SearchOption.AllDirectories);
                        foreach (var file in files){
                            var filename = Path.GetFileName(file);
                            var filepath = file.Substring(0, file.Length - filename.Length);
                            //Skip invalid UnrealEngine.dll
                            if (filename == "UnrealEngine.dll"){
                                if ((aot_target == "armv7" || aot_target == "armv7s") && !filepath.Contains("Game_32bits")){
                                    continue;
                                } else if (aot_target == "arm64" && !filepath.Contains("Game_64bits")){
                                    continue;
                                }
                            }
                            UObject.LogInfo("copy {0} to {1}", filename, outpath);
                            File.Copy(file, Path.Combine(temppath, filename), true);
                        }
                    }
                }

                //AOT all files for the temp folder
                {
                    var files = Directory.GetFiles(temppath, "*.dll", SearchOption.AllDirectories);
                    foreach (var file in files){
                        var filename = Path.GetFileName(file);
                        var filepath = file.Substring(0, file.Length - filename.Length);

                        //Skip this file
                        if (filename == "mscorlib.dll"){
                            aot_filename_list.Add("mono_aot_module_mscorlib_info");
                            //copy mscorlib.dll.a
                            File.Copy(Path.Combine(mscorlib_path, "mscorlib.dll.a"), Path.Combine(outpath, "mscorlib.dll.a"));
                            //File.Copy(Path.Combine(mscorlib_path, "mscorlib.dll.s"), Path.Combine(ios_private_path, "mscorlib.dll.s"),true);
                            continue;
                        }

                        //AOT
                        {
                            System.Environment.CurrentDirectory = MAC_AOT_MONO_PATH;

                            var proc = new System.Diagnostics.Process();
                            proc.StartInfo.WorkingDirectory = MAC_AOT_MONO_PATH;
                            if (isWindows){
                                proc.StartInfo.FileName = Path.Combine(MAC_AOT_MONO_PATH, "mono-sgen.exe");
                                proc.StartInfo.Arguments = $" --aot=full,asmonly,static \"{file}\"";
                            } else{
                                proc.StartInfo.FileName = "./armv7-apple-darwin-mono-sgen";
                                proc.StartInfo.Arguments = $"--aot=full,asmonly,static,nrgctx-trampolines=8096,nimt-trampolines=8096,ntrampolines=4048 \"{file}\"";
                            }

                            proc.StartInfo.CreateNoWindow = true;
                            proc.StartInfo.UseShellExecute = false;
                            proc.StartInfo.RedirectStandardOutput = true;
                            proc.StartInfo.RedirectStandardError = true;
                            proc.OutputDataReceived += OutputHandler;
                            proc.ErrorDataReceived += ErrorHandler;

                            UObject.LogInfo("aot {0}", proc.StartInfo.Arguments);
                            proc.Start();

                            proc.BeginOutputReadLine();
                            proc.BeginErrorReadLine();

                            proc.WaitForExit();
                            proc.Close();

                            //Copy to the Private / IOS directory
                            //File.Copy(file+".s", Path.Combine(ios_private_path, filename +".s"), true);
                        }

                        if (isMac){
                            //AS
                            {
                                var proc = new Process{
                                    StartInfo = {
                                        WorkingDirectory = filepath,
                                        FileName = "xcrun",
                                        Arguments = string.Format("-sdk iphoneos as -arch {2} -mno-thumb -miphoneos-version-min=7.0 -isysroot /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS.sdk -o {0}.o {1}.s", filename, filename, aot_target),
                                        CreateNoWindow = true,
                                        UseShellExecute = false,
                                        RedirectStandardOutput = true,
                                        RedirectStandardError = true
                                    }
                                };
                                //proc.StartInfo.FileName = "as";
                                //proc.StartInfo.Arguments = string.Format("-arch {2} -march=armv7-a -mno-thumb -miphoneos-version-min=7.0 -isysroot /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS.sdk -o {0}.o {1}.s", filename, filename, aot_target);

                                proc.OutputDataReceived += OutputHandler;
                                proc.ErrorDataReceived += ErrorHandler;

                                UObject.LogInfo("as {0}", proc.StartInfo.Arguments);
                                proc.Start();

                                proc.BeginOutputReadLine();
                                proc.BeginErrorReadLine();

                                proc.WaitForExit();
                                proc.Close();
                            }

                            //ar
                            {
                                var proc = new Process{
                                    StartInfo = {
                                        WorkingDirectory = filepath,
                                        FileName = "xcrun",
                                        Arguments = $"-sdk iphoneos ar rcu \"{Path.GetFullPath(Path.Combine(outpath, filename))}.a\" {filename}.o",
                                        CreateNoWindow = true,
                                        UseShellExecute = false,
                                        RedirectStandardOutput = true,
                                        RedirectStandardError = true
                                    }
                                };
                                //proc.StartInfo.FileName = "ar";
                                //proc.StartInfo.Arguments = string.Format("-r \"{0}.a\" {1}.o", Path.GetFullPath(Path.Combine(outpath, filename)), filename);


                                proc.OutputDataReceived += OutputHandler;
                                proc.ErrorDataReceived += ErrorHandler;

                                UObject.LogInfo("ar {0}", proc.StartInfo.Arguments);
                                proc.Start();

                                proc.BeginOutputReadLine();
                                proc.BeginErrorReadLine();

                                proc.WaitForExit();
                                proc.Close();
                            }
                        }
                    }
                }

                //Delete the temp folder
                {
                    Directory.Delete(temppath, true);
                }

                //Build ios pre-defined header files
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("extern \"C\"{");
                sb.AppendLine("\tvoid mono_aot_register_module(void* pt);");
                foreach (var filename in aot_filename_list){
                    sb.AppendFormat("\textern void* {0};", filename);
                    sb.AppendLine();
                }
                sb.AppendLine("}");

                sb.AppendLine("void RegisterMonoModules(){");
                foreach (var filename in aot_filename_list){
                    sb.AppendFormat("\tmono_aot_register_module({0});", filename);
                    sb.AppendLine();
                }
                sb.AppendLine("}");
                aot_filename_list.Clear();
                //写入文件
                File.WriteAllText(ios_predefine_header_file_pathname, sb.ToString(), System.Text.Encoding.UTF8);
            } catch (Exception e){
                UObject.LogError(e.Message);
                UObject.LogError(e.StackTrace);
            } finally{
                System.Environment.CurrentDirectory = last_work_dir;
            }
        }

        private static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine){
            // Collect the sort command output.
            if (!string.IsNullOrEmpty(outLine.Data)){
                var r = new Regex("mono_aot_module_[\\s\\S]*_info");

                var m = r.Match(outLine.Data);
                if (m.Success){
                    instance.aot_filename_list.Add(m.ToString());
                }
                UObject.LogWarning(outLine.Data);
            }
        }

        private static void ErrorHandler(object sendingProcess, DataReceivedEventArgs outLine){
            // Collect the sort command output.
            if (!string.IsNullOrEmpty(outLine.Data)){
                UObject.LogError(outLine.Data);
            }
        }

        private void Start(){
            if (gameDomain == null){
                var domaininfo = new AppDomainSetup{
                    ApplicationName = gameName,
                    DisallowApplicationBaseProbing = true
                };
                //domaininfo.ShadowCopyDirectories = gameAssembliesDir;// string.Join(System.IO.Path.PathSeparator.ToString(), engineAssembliesDir, gameAssembliesDir);
                //domaininfo.ShadowCopyFiles = "true";
                //domaininfo.CachePath = shadowCopyDirectory;
                gameDomain = AppDomain.CreateDomain("Game", AppDomain.CurrentDomain.Evidence, domaininfo);
                //gameDomain = AppDomain.CreateDomain("Game");
            }
        }

        private void End(){
            if (gameDomain != null){
                //UnrealEngine.UObject.Log("Unload Game Domain");
                //AppDomain.Unload(gameDomain);
                gameDomain = null;
            }
        }

        private void ClearAndRenameAssembly(){
            //Find the latest file
            var files = Directory.GetFiles(gameAssembliesDir);
            var lastFileName = "";

            var max_number = -1;
            foreach (var file in files){
                var startIndex = file.LastIndexOf('-');
                var endIndex = file.LastIndexOf('.');
                if (startIndex == -1 || endIndex == -1){
                    continue;
                }

                var numStr = file.Substring(startIndex + 1, (endIndex - startIndex) - 1);

                try{
                    var num = int.Parse(numStr);
                    if (max_number < num){
                        max_number = num;
                        lastFileName = file;
                    }
                } catch (Exception e){ }
            }

            if (max_number >= 0){
                //Delete the previous file
                foreach (var f in files){
                    if (f != lastFileName){
                        UnrealEngine.UObject.LogInfo("DeleteFile " + f);
                        File.Delete(f);
                    }
                }
                //UnrealEngine.UObject.Log("Move " + lastFileName);
                //File.Move(lastFileName, Path.Combine(gameAssembliesDir, "Game.dll"));
            }
        }

        public void HotReload(){
            if (withEidtor){
                End();
                ClearAndRenameAssembly();
            }
            Start();
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void NativeReload();

        public static Main Initialize(string gameName, string pluginBaseDir, string engineAssembliesDir, string gameAssembliesDir, string shadowCopyDirectory, int withEidtor){
            instance = new Main(gameName, pluginBaseDir, engineAssembliesDir, gameAssembliesDir, shadowCopyDirectory, withEidtor);
            return instance;
        }

        public static void Shutdown(){
            if (instance != null){
                instance.End();
                instance = null;
            }
        }
    }
}