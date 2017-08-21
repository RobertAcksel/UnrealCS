using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnrealEngine{
    internal class EditorCommands{
        internal static void OpenProject(string pluginBaseDir){
#if WITH_EDITOR
            var sourceDir = Path.Combine(pluginBaseDir, "Project");
            var destinationDir = Path.Combine(FPaths.GameDir(), "Project");
            var solutionPath = Path.Combine(FPaths.GameDir(), "Project", "Script.sln");
            //Check the script works
            if (!Directory.Exists(destinationDir)){
                //Copy the script template to the project directory
                UObject.LogInfo($"Copy script project template from '{sourceDir}' to '{destinationDir}'");
                CopyFolder(destinationDir, sourceDir);
            }

            if (UGameplayStatics.GetPlatformName() == "Windows"){
                var installDir = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\devenv.exe", null, "").ToString();
                if (string.IsNullOrEmpty(installDir)){
                    UObject.LogError("Can't find devenv.exe");
                    return;
                }
                Process.Start(installDir, solutionPath);
            } else{
                //No tool to display item location
                UObject.LogWarning("C# script solution file located at " + solutionPath);
            }
#endif
        }

        private static void CopyFolder(string dest, string src){
            if (!(dest.EndsWith("\\") || dest.EndsWith("/")))
                dest += "/";
            if (!(src.EndsWith("\\") || src.EndsWith("/")))
                src += "/";
            if (!Directory.Exists(dest))
                Directory.CreateDirectory(dest);

            // subfolders
            foreach (var sub in Directory.GetDirectories(src, "*", SearchOption.TopDirectoryOnly)){
                var name = Path.GetFileName(sub);
                CopyFolder(Path.Combine(dest, name), Path.Combine(src, name));
            }

            // files
            foreach (var file in Directory.GetFiles(src, "*", SearchOption.TopDirectoryOnly)){
                var name = Path.GetFileName(file);
                File.Copy(Path.Combine(src, name), Path.Combine(dest, name), true);
            }
        }
    }
}