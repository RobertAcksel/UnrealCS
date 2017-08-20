using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnrealEngine;

namespace MainDomain{
    internal class AOTSupport{
        private readonly Main main;
        private List<string> aotFilenameList = null;

        public AOTSupport(Main main){
            this.main = main;
        }

        public List<string> AotFilenameList{ get => aotFilenameList; set => aotFilenameList = value; }

        public void AOT(){
            UObject.LogInfo("AOT Start");

            aotFilenameList = new List<string>();
            aotFilenameList.Clear();

            var last_work_dir = System.Environment.CurrentDirectory;
            try{
                var isWindows = UGameplayStatics.GetPlatformName() == "Windows";
                var isMac = UGameplayStatics.GetPlatformName() == "Mac";

                if (!isWindows && !isMac)
                    return;

                //Traverse the directory, aot each file
                var MAC_AOT_MONO_PATH = Path.GetFullPath(isWindows ? Path.Combine(main.pluginBaseDir, "mono_aot", "aot_host_windows_target_armv7", "bin") : Path.Combine(main.pluginBaseDir, "mono_aot", "aot_host_mac_target_armv7", "bin"));

                var aot_target = "armv7";
                var mscorlib_path = Path.GetFullPath(Path.Combine(main.pluginBaseDir, "mono_aot", "pre_aot_files", aot_target));

                var ios_predefine_header_file_pathname = Path.GetFullPath(Path.Combine(main.pluginBaseDir, "Source", "MonoPlugin", "Private", "ios_predefine.h"));
                var ios_private_path = Path.GetFullPath(Path.Combine(main.pluginBaseDir, "Source", "MonoPlugin", "Private", "IOS"));

                var outpath = Path.GetFullPath(Path.Combine(main.pluginBaseDir, "AOT"));
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
                        main.engineAssembliesDir,
                        main.gameAssembliesDir,
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
                            aotFilenameList.Add("mono_aot_module_mscorlib_info");
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
                            proc.OutputDataReceived += Main.OutputHandler;
                            proc.ErrorDataReceived += Main.ErrorHandler;

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

                                proc.OutputDataReceived += Main.OutputHandler;
                                proc.ErrorDataReceived += Main.ErrorHandler;

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


                                proc.OutputDataReceived += Main.OutputHandler;
                                proc.ErrorDataReceived += Main.ErrorHandler;

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
                foreach (var filename in aotFilenameList){
                    sb.AppendFormat("\textern void* {0};", filename);
                    sb.AppendLine();
                }
                sb.AppendLine("}");

                sb.AppendLine("void RegisterMonoModules(){");
                foreach (var filename in aotFilenameList){
                    sb.AppendFormat("\tmono_aot_register_module({0});", filename);
                    sb.AppendLine();
                }
                sb.AppendLine("}");
                aotFilenameList.Clear();
                //写入文件
                File.WriteAllText(ios_predefine_header_file_pathname, sb.ToString(), System.Text.Encoding.UTF8);
            } catch (Exception e){
                UObject.LogError(e.Message);
                UObject.LogError(e.StackTrace);
            } finally{
                System.Environment.CurrentDirectory = last_work_dir;
            }
        }
    }
}