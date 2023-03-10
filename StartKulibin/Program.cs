using System;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;

// var appdata_var = Environment.GetEnvironmentVariable("APPDATA");
// var install_path = ".\\Kulibin.exe";

// var install_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kulibin.exe");
// Process prc = new Process(); 
// prc.StartInfo.FileName = install_path; 
// prc.Start();
// Console.ReadKey();


// class FindKulibin
// {
//     public static void Main()
//     {
//         try
//         {
//             string[] dirs = Directory.GetFiles(@"C:\Users\koshe\", "*");
//             Console.WriteLine("The number of files starting with Kulibin is {0}.", dirs.Length);
//             foreach (string dir in dirs)
//             {
//                 Console.WriteLine(dir);
//             }
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine("The process failed: {0}", e.ToString());
//         }
//     }
// }

string folderPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

string[] pathParts = folderPath.Split(Path.DirectorySeparatorChar);
Array.Resize(ref pathParts, pathParts.Length-5);
string fullPath = Path.Combine(pathParts);

var executePath = Path.Combine(fullPath, "Kulibin.dll");
Process prc = new Process();
prc.StartInfo.FileName = executePath;
prc.Start();

Console.WriteLine(fullPath);

// DirectoryInfo perDir = Directory.GetParent(folderPath);
// string perPath = perDir.FullName;
//
// Console.WriteLine(perPath);
// string appFilename = "Kulibin.exe";
// string appFullPath = Path.Combine(perPath, appFilename);
//
// Process.Start(appFullPath);