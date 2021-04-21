using System;
using System.Threading;
using System.Security.Permissions;
using System.Security.Principal;
using System.Diagnostics;

namespace Level_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            ItemProcess();
            ProcessAnd();

        }
        static void ItemProcess()
        {
            Process[] procs = Process.GetProcesses();

            foreach (Process item in procs)
            {
                Console.WriteLine($"Название процесса: {item.ProcessName}, id:{item.Id}");
            }
        }
        static void ProcessAnd()
        {
            Console.WriteLine("введите Id процесса для закрытия: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Если хотите убить процесс, нажмите 2, если хотите просто закрыть приложение - 1");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Process p = Process.GetProcessById(b);
                    p.CloseMainWindow();
                    break;
                case 2:
                    Process p2 = Process.GetProcessById(b);
                    p2.Kill();
                    break;
            }               
        }
    }
}
