using System;
using System.IO;

namespace copy{
    class Program{
        static void Main(string[] args){
            if (args.Length < 2){
                Console.Out.WriteLine("This program will automatically copy the source file to the target directory. If the target directory already has the same file, change the source file name and add a higher numeric suffix. Specify the copy source file and destination directory: Parameter 1: Source file parameter 2 : Target directory");
                return;
            }

            var sourceFileName = new FileInfo(args[0]);
            var targetFolder = new DirectoryInfo(Path.GetFullPath(args[1]));
            Console.Out.WriteLine($"Copy {sourceFileName.Name} to {targetFolder.FullName}");

            var fileName = Path.GetFileNameWithoutExtension(sourceFileName.FullName);

            if (!targetFolder.Exists){
                targetFolder.Create();
            }

            Console.Out.WriteLine("Detect the latest file ...");

            var files = targetFolder.GetFiles("*.dll");
            var maxNumber = FindGameAssemblyVersionNumber(files);

            var targetFullFileName = targetFolder.FullName + "/" + fileName + "-" + maxNumber + ".dll";

            try{
                File.Copy(sourceFileName.FullName, targetFullFileName, true);
                var pdbFile = new FileInfo(Path.ChangeExtension(sourceFileName.FullName, ".pdb"));
                Console.Out.WriteLine("Copy successful " + targetFullFileName);
                if (pdbFile.Exists){
                    var destFileName = Path.ChangeExtension(targetFullFileName, ".pdb");
                    File.Copy(pdbFile.FullName, destFileName, true);
                    Console.Out.WriteLine("Copy successful " + destFileName);
                }
            } catch (Exception e){
                Console.Out.WriteLine("Copy failed:" + e.Message);
            }
        }

        private static int FindGameAssemblyVersionNumber(FileInfo[] files){
            var maxNumber = 0;
            foreach (var fi in files){
                var startIndex = fi.Name.LastIndexOf('-') + 1;
                var endIndex = fi.Name.LastIndexOf('.');
                var f = fi.Name.Substring(startIndex, endIndex - startIndex);
                try{
                    var num = Int32.Parse(f);
                    if (num >= maxNumber){
                        maxNumber = num + 1;
                    }
                } catch (Exception e){
                    Console.Out.WriteLine(fi.Name + " The name is wrong：" + e.Message);
                }
            }

            return maxNumber;
        }
    }
}