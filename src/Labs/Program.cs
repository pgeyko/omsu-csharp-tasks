using System;
using Labs.Utils;
using Labs.Tasks;

namespace Labs
{
    public class Program
    {
        private const int NumTask = 2;
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintHelp();
                return;
            }
            var parsed = CmdArgsParser.Parse(args);
            if (!ArgsValidator.TryGetTask(parsed, out int task, NumTask))
                return;

            switch (task)
            {
                case 1:
                    Task1.Run(parsed);
                    break;
                case 2:
                    Task2.Run(parsed);
                    break;
                default:
                    Console.WriteLine("ERROR: Unknown task.");
                    break;
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine("HELP:");
            Console.WriteLine("    --task - task number");
            Console.WriteLine("    -x - value of X");
            Console.WriteLine("    -y - value of Y");
            Console.WriteLine("    -z - value of Z");
            Console.WriteLine("    -d1st - start of the first date segment (DD.MM.YYYY)");
            Console.WriteLine("    -d1end - end of the first date segment (DD.MM.YYYY)");
            Console.WriteLine("    -d2st - start of the second date segment (DD.MM.YYYY)");
            Console.WriteLine("    -d2end - end of the second date segment (DD.MM.YYYY)");
        }
    }
}
