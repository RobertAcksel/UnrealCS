using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy{
    class Program{
        static void Main(string[] args){
            if (args.Length < 2){
                Console.Out.WriteLine("This program will automatically copy the source file to the target directory. If the target directory already has the same file, change the source file name and add a higher numeric suffix. Specify the copy source file and destination directory: Parameter 1: Source file parameter 2 : Target directory");
                return;
            }
            Console.Out.WriteLine($"Copy {args[0]} to {args[1]}");

            var indexPath = args[0].LastIndexOf('/');
            var indexDll = args[0].LastIndexOf('.');

            if (indexDll == -1){
                indexDll = args[0].Length;
                args[0] += ".dll";
            }

            var fileName = indexPath != -1 ? args[0].Substring(indexPath, indexDll - indexPath) : args[0].Substring(0, indexDll);

            var targetFolder = new DirectoryInfo(args[1]);

            if (!Directory.Exists(args[1])){
                Directory.CreateDirectory(args[1]);
            }

            Console.Out.WriteLine("Detect the latest file ...");

            var max_number = 0;
            var files = targetFolder.GetFiles();
            foreach (var fi in files){
                var startIndex = fi.Name.LastIndexOf('-') + 1;
                var endIndex = fi.Name.LastIndexOf('.');
                var f = fi.Name.Substring(startIndex, endIndex - startIndex);
                try{
                    var num = Int32.Parse(f);
                    if (num >= max_number){
                        max_number = num + 1;
                    }
                } catch (Exception e){
                    Console.Out.WriteLine(fi.Name + " The name is wrong：" + e.Message);
                }
            }

            //Directory make up the backslash
            if (args[1][args[1].Length - 1] != '/')
                args[1] += "/";

            var targetFileName = args[1] + fileName + "-" + max_number + ".dll";

            //string targetFileName = args[1] + args[0];
            try{
                File.Copy(args[0], targetFileName, true);
                Console.Out.WriteLine("Copy successful " + targetFileName);
            } catch (Exception e){
                Console.Out.WriteLine("Copy failed:" + e.Message);
            }
        }
    }
}