using System;
using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;
using System.IO;
using UnrealEngine;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

//using System.Linq;
//using System.Reflection;

namespace MainDomain{
    public class MainClass{
        public static void Main(string[] args){
            while (true){
                Thread.Sleep(1000);
                if (Debugger.IsAttached){
                    //                    Method();
                    Thread.Sleep(1000);
                    Console.WriteLine("Write an empty line! You may test to attach a debugger?");
                }
            }
        }

        private static MainClass instance;

        private readonly bool withEidtor;
        private readonly string gameName;
        internal readonly string pluginBaseDir;
        internal readonly string engineAssembliesDir;
        internal readonly string gameAssembliesDir;
        private string shadowCopyDirectory;
//        internal AOTSupport AotSupport { get; }

        private AppDomain gameDomain;
        private readonly List<FileSystemWatcher> fileWatchers = new List<FileSystemWatcher>();

//        [MethodImpl(MethodImplOptions.InternalCall)]
//        public static extern void NativeReload();
//
//        [MethodImpl(MethodImplOptions.InternalCall)]
//        public static extern void NativeReinitsystem();

        public MainClass(string gameName, string pluginBaseDir, string engineAssembliesDir, string gameAssembliesDir, string shadowCopyDirectory, int withEidtor){
            this.withEidtor = withEidtor != 0;
            this.gameName = gameName;
            this.pluginBaseDir = pluginBaseDir;
            this.engineAssembliesDir = engineAssembliesDir;
            this.gameAssembliesDir = gameAssembliesDir;
            this.shadowCopyDirectory = shadowCopyDirectory;

            if (this.withEidtor)
                CreateFileWatcher();
//            AotSupport = new AOTSupport(this);
        }

        private void CreateFileWatcher(){
            {
                //Open the file monitoring service
                var fsw = new FileSystemWatcher(gameAssembliesDir){
                    Filter = "*.dll",
                    NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.FileName 
                };
                fsw.Created += Fsw_Created;
                fsw.Error += Fsw_Error;
                fsw.IncludeSubdirectories = false;
                fsw.InternalBufferSize = 10240;
                fsw.EnableRaisingEvents = true;

                fileWatchers.Add(fsw);
//                UnrealEngine.UObject.LogInfo("Start file hot reload listens at '" + fsw.Path + "Game.dll'");
            }

            {
                //Open the file monitoring service
                var fsw = new FileSystemWatcher(pluginBaseDir+ "/Scripts/EngineAssemblies")
                {
                    Filter = "*.dll",
                    NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.FileName
                };
                fsw.Changed += Fsw_EngineAssembliesUpdated;
                fsw.Created += Fsw_EngineAssembliesUpdated;
                //fsw.Deleted += Fsw_Deleted;
                fsw.Error += Fsw_Error;
                //fsw.Renamed += Fsw_Renamed;
                fsw.IncludeSubdirectories = false;
                fsw.InternalBufferSize = 10240;
                fsw.EnableRaisingEvents = true;

                fileWatchers.Add(fsw);
//                UnrealEngine.UObject.LogInfo("Start file reload listens at '" + fsw.Path + "'");
            }
        }

        private void Fsw_EngineAssembliesUpdated(object sender, FileSystemEventArgs e){
            //this will move dlls in use to a temporary folder
            var files = Directory.GetFiles(engineAssembliesDir, "*.dll", SearchOption.AllDirectories);
            foreach (var filePath in files){
                var fileInfo = new FileInfo(filePath);
                if (IsFileLocked(fileInfo)){
//                    UObject.LogInfo($"Moved old file to '{anotherName}'");
                    var fileName = fileInfo.FullName.Replace(engineAssembliesDir, "");
                    var tempPath = Path.Combine(Path.GetTempPath(), "UnrealEditor_CSharp_dlls");
                    var destFileName = tempPath + fileName;
                    if (File.Exists(destFileName)){
                        try{
                            File.Delete(destFileName);
                        } catch{
                            var count = 0;
                            while (true){
                                var anotherName = destFileName + (count++);
                                try{
                                    File.Move(destFileName, anotherName);
                                    UObject.LogWarning($"Moved old file to '{anotherName}'");
                                    break;
                                } catch{ // ignored 
                                }
                            }
                        }
                    }
                    fileInfo.MoveTo(destFileName);
                }
            }

            UnrealEngine.UObject.LogInfo("reload' " + engineAssembliesDir + "'");
//            NativeReinitsystem();
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
            if (withEidtor){
                CecilHook.PostProcessAssembly(e);
            }
//            NativeReload();
        }

        private void Fsw_Changed(object sender, FileSystemEventArgs e){
            UnrealEngine.UObject.LogInfo("Fsw_Changed:" + e.Name);
//            NativeReload();
        }

        public void OnCommand(string cmd){
            switch (cmd){
                case "OpenProject":
                    OpenProject();
                    break;
                case "AOT":
//                    AotSupport.AOT();
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
//                var installDir = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\devenv.exe",null, "").ToString();
//                if (string.IsNullOrEmpty(installDir)){
//                    UObject.LogError("Can't find devenv.exe");
//                    return;
//                }
//                Process.Start(installDir, solutionPath);
            } else{
                //No tool to display item location
                UObject.LogWarning("C# script solution file located at " + solutionPath);
            }
        }

        internal static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine){
            // Collect the sort command output.
            if (!string.IsNullOrEmpty(outLine.Data)){
                var r = new Regex("mono_aot_module_[\\s\\S]*_info");

                var m = r.Match(outLine.Data);
                if (m.Success){
//                    instance.AotSupport.AotFilenameList.Add(m.ToString());
                }
                UObject.LogWarning(outLine.Data);
            }
        }

        internal static void ErrorHandler(object sendingProcess, DataReceivedEventArgs outLine){
            // Collect the sort command output.
            if (!string.IsNullOrEmpty(outLine.Data)){
                UObject.LogError(outLine.Data);
            }
        }

        private void Start(){
            if (gameDomain == null){
//                var domaininfo = new AppDomainSetup{
//                    ApplicationName = gameName,
//                    DisallowApplicationBaseProbing = true
//                };

//                var loadFile = Assembly.LoadFile();

                //domaininfo.ShadowCopyDirectories = gameAssembliesDir;// string.Join(System.IO.Path.PathSeparator.ToString(), engineAssembliesDir, gameAssembliesDir);
                //domaininfo.ShadowCopyFiles = "true";
                //domaininfo.CachePath = shadowCopyDirectory;
//                gameDomain = AppDomain.CreateDomain("Game", AppDomain.CurrentDomain.Evidence, domaininfo);
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

        public static MainClass Initialize(string gameName, string pluginBaseDir, string engineAssembliesDir, string gameAssembliesDir, string shadowCopyDirectory, int withEidtor){
            instance = new MainClass(gameName, pluginBaseDir, engineAssembliesDir, gameAssembliesDir, shadowCopyDirectory, withEidtor);
            return instance;
        }

        public static void Shutdown(){
            if (instance != null){
                instance.End();
                instance = null;
            }
        }

        public static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally{
                stream?.Close();
            }

            //file is not locked
            return false;
        }
    }
}