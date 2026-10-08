using System;
using Labs.Utils;
using Labs.Tasks;

namespace Labs
{
    public class Program
    {
        private const int NumTask = 1;
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintHelp();
                return;
            }
            var parsed = CmdArgsParser.Parse(args);
            if (!ArgsValidator.TryValidate(parsed, out int task, out int x, out int y, out int z, NumTask))
                return;

            switch (task)
            {
                case 1:
                    Task1.Run(x, y, z);
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
        }
    }
}
