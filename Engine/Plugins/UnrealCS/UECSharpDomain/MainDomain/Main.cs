using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;
using UnrealEngine;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq;

namespace MainDomain{
    internal class Main{
        private static Main instance;

        private readonly bool withEidtor;
        private readonly string gameName;
        internal readonly string pluginBaseDir;
        internal readonly string engineAssembliesDir;
        internal readonly string gameAssembliesDir;
        private string shadowCopyDirectory;
        internal AOTSupport AotSupport { get; }

        private AppDomain gameDomain;
        private readonly List<FileSystemWatcher> fileWatchers = new List<FileSystemWatcher>();

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void NativeReload();

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void NativeReinitsystem();

        public Main(string gameName, string pluginBaseDir, string engineAssembliesDir, string gameAssembliesDir, string shadowCopyDirectory, int withEidtor){
            this.withEidtor = withEidtor != 0;
            this.gameName = gameName;
            this.pluginBaseDir = pluginBaseDir;
            this.engineAssembliesDir = engineAssembliesDir;
            this.gameAssembliesDir = gameAssembliesDir;
            this.shadowCopyDirectory = shadowCopyDirectory;

            if (this.withEidtor)
                CreateFileWatcher();
            AotSupport = new AOTSupport(this);
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
            NativeReinitsystem();
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
            NativeReload();
        }

        private void Fsw_Changed(object sender, FileSystemEventArgs e){
            UnrealEngine.UObject.LogInfo("Fsw_Changed:" + e.Name);
            NativeReload();
        }

        public void OnCommand(string cmd){
            switch (cmd){
                case "OpenProject":
                    EditorCommands.OpenProject(pluginBaseDir);
                    break;
                case "AOT":
                    AotSupport.AOT();
                    break;
                default:
                    break;
            }
        }

        internal static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine){
            // Collect the sort command output.
            if (!string.IsNullOrEmpty(outLine.Data)){
                var r = new Regex("mono_aot_module_[\\s\\S]*_info");

                var m = r.Match(outLine.Data);
                if (m.Success){
                    instance.AotSupport.AotFilenameList.Add(m.ToString());
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

            lastFileName = Path.GetFullPath(lastFileName);

            if (max_number >= 0){
                //Delete the previous file
                foreach (var f in files){
                    var pdbFile = Path.Combine(Path.GetDirectoryName(lastFileName), Path.GetFileNameWithoutExtension(lastFileName)) + ".pdb";
                    var fNormalized = Path.GetFullPath(f);

                    if (fNormalized != lastFileName && fNormalized != pdbFile){
                        UnrealEngine.UObject.LogInfo("DeleteFile " + fNormalized);
                        File.Delete(fNormalized);
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