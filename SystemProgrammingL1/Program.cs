using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgrammingL1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var currentProcess = Process.GetCurrentProcess();
            //Console.WriteLine(currentProcess.ProcessName);
            //var notepadProcess = Process.Start("notepad.exe");
            ////notepadProcess = Process.Start("calc.exe");
            //for (int x = 0; x < 10; x++)
            //{
            //    notepadProcess.Start();
            //}
            //if (Console.ReadKey().Key == ConsoleKey.E)
            //{
            //    var allProcess = Process.GetProcesses();
            //    foreach (var p in allProcess)
            //    {
            //        if (p.ProcessName == notepadProcess.ProcessName)
            //        {
            //            p.Kill();
            //        }
            //    }
            //}

            //var allProcesses = Process.GetProcesses().Where(p => p.ProcessName == "notepad").ToList();
            //for (int i = 0; i < allProcesses.Count - 1; i++)
            //{
            //    allProcesses[i].Kill();
            //}

            Thread thread = new Thread(() =>
            {
                Process.Start("notepad.exe");
            });
            thread.Start();

            Thread thread2 = new Thread(() =>
            {
                Process.Start("calc.exe");
            });
            thread2.Start();
        }
    }
}
