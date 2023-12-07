using System.Diagnostics;

namespace BetterTaskkill
{
    public class Program
    {
        static void Main()
        {
            Console.Clear(); Console.WriteLine("State a Methode\n\n 1. By Name\n 2. By PID\n\n");
            var Answer = Console.ReadLine();
            switch (Answer)
            {
                case "1":
                    Method1(""); break;
                case "2":
                    Method2(0); break;
            }
            Main();
        }

        static void Method1(string Answer)
        {
            Console.Clear(); Console.WriteLine("State a Process Name:\n\n");
            Answer = Console.ReadLine();
            Process[] procs = Process.GetProcessesByName(Answer);

            if (Answer != "" && Answer != null) foreach (Process p in procs) { p.Kill(); }
            Console.Clear(); Main();
        }

        static void Method2(int Answer)
        {
            Console.Clear(); Console.WriteLine("State a PID Number:\n\n");
            int.TryParse(Console.ReadLine(), out Answer);
            Process procs = Process.GetProcessById(Answer);

            if (Answer != 0) procs.Kill();
            Console.Clear(); Main();
        }
    }
}
