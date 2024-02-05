using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client 1
            ProcessManager.ShowProcessList(p => true);

            // client 2

            //ProcessManager.ShowProcessList(FilterByName);

            // Anonymous Delegates
            ProcessManager.ShowProcessList(delegate (Process process)
            {
                return process.ProcessName.StartsWith("S");
            });

            // Lambda statments
            ProcessManager.ShowProcessList((Process process) =>
            {
                return process.ProcessName.StartsWith("S");
            });

            // Lambda Expressions
            ProcessManager.ShowProcessList((Process process) =>

                 process.ProcessName.StartsWith("S")
            );

            // Lambda Expressions
            ProcessManager.ShowProcessList(process => process.ProcessName.StartsWith("S"));


            // client 3
            //ProcessManager.ShowProcessList(FilterBySize);

        }

        // client 1
        public static bool FilterByNone(Process process) { return true; }

        // client 2
        public static bool FilterByName(Process process)
        {
            return process.ProcessName.StartsWith("S");
        }


        // client 3
        public static bool FilterBySize(Process p)
        {
            return p.WorkingSet64 > 100 * 1024 * 1024;
        }
    }


    public delegate bool FilterDelegate(Process p);


    // Backend code - 
    class ProcessManager
    {
        //public static void ShowProcessList()
        //{
        //    foreach (var p in Process.GetProcesses())
        //    {
        //        Console.WriteLine(p.ProcessName);
        //    }
        //}

        //public static void ShowProcessList(string sw)
        //{
        //    foreach (var p in Process.GetProcesses())
        //    {
        //        if (p.ProcessName.StartsWith(sw))
        //            Console.WriteLine(p.ProcessName);
        //    }
        //}

        public static void ShowProcessList(FilterDelegate filter)
        {
            foreach (var p in Process.GetProcesses())
            {
                if (filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}
