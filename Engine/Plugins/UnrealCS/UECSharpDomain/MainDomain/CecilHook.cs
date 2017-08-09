using System.IO;
using Mono.Cecil;
using UnrealEngine;

namespace MainDomain{
    internal static class CecilHook{
        public static void PostProcessAssembly(FileSystemEventArgs fileSystemEventArgs){
            var file = fileSystemEventArgs.FullPath;
            var module = ModuleDefinition.ReadModule(file);
            foreach (var type in module.Types){
                for (var i = type.Methods.Count - 1; i >= 0; i--){
                    var method = type.Methods[i];
                    foreach (var attribute in method.CustomAttributes){
                        if (attribute.GetType() == typeof(AssemblyRemoved)){
                            method.IsRemoveOn = true;
                            break;
                        }
                    }
                }
            }
            module.Write(file);
        }
    }
}