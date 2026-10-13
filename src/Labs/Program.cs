using Labs.Exceptions;
using Labs.InputOutput;
using Labs.Tasks;

namespace Labs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                HelpMessage.PrintHelp();
                return;
            }
            try
            {
                var parsed = CmdArgsParser.Parse(args);
                if (!ArgsValidator.TryGetTask(parsed, out int num, NumTask: 3))
                    return;
                BaseTask? task = CreateTask(parsed, num);
                if (task is null)
                    return;


                task.Execute();
            }
            catch (ValidationException ex)
            {
                CmdOutput.CmdWriteLine("ERROR: " + ex.Message);
            }
        }

        private static BaseTask? CreateTask(Dictionary<string, string?> parsed, int num)
        {
            switch (num)
            {
                case 1:
                    ArgReader.TryGetInt(parsed, "x", out int x);
                    ArgReader.TryGetInt(parsed, "y", out int y);
                    ArgReader.TryGetInt(parsed, "z", out int z);
                    return new Task1(x, y, z);
                case 2:
                    ArgReader.TryGetDate(parsed, "d1st", out DateTime d1st);
                    ArgReader.TryGetDate(parsed, "d1end", out DateTime d1end);
                    ArgReader.TryGetDate(parsed, "d2st", out DateTime d2st);
                    ArgReader.TryGetDate(parsed, "d2end", out DateTime d2end);
                    return new Task2(d1st, d1end, d2st, d2end);
                case 3:
                    ArgReader.TryGetStr(parsed, "s1", out string s1);
                    ArgReader.TryGetStr(parsed, "s2", out string s2);
                    return new Task3(s1, s2);
                default:
                    CmdOutput.CmdWriteLine("ERROR: Unknown task.");
                    return null;
            }
        }
    }
}
