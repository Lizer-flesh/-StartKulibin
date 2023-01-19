using System;
using System.Diagnostics;

var appdata_var = Environment.GetEnvironmentVariable("APPDATA");
var install_path = appdata_var + "\\Kulibin\\Kulibin.exe";
Process prc = new Process(); 
prc.StartInfo.FileName = install_path; 
prc.Start();