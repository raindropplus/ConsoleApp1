using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            foreach (var proc in processes)
            {
                if (!string.IsNullOrEmpty(proc.MainWindowTitle))
                    Console.WriteLine(proc.ProcessName);
                if (proc.ProcessName.ToUpper() == "NOTEPAD")
                {
                    proc.Kill();
                }
            }
            Console.ReadKey();
        }
    }
}
