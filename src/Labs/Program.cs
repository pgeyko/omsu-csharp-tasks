using Labs.Exceptions;
using Labs.InputOutput;
using Labs.Tasks;
using Labs.Utils;

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
            var parsed = CmdArgsParser.Parse(args);
            if (!ArgsValidator.TryGetTask(parsed, out int num, NumTask: 3))
                return;
            BaseTask? task = CreateTask(parsed, num);
            if (task is null)
                return;

            try
            {
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
                    if (!ArgReader.TryGetInt(parsed, "x", out int x)) return null;
                    if (!ArgReader.TryGetInt(parsed, "y", out int y)) return null;
                    if (!ArgReader.TryGetInt(parsed, "z", out int z)) return null;
                    return new Task1(x, y, z);
                case 2:
                    if (!ArgReader.TryGetDate(parsed, "d1st", out DateTime d1st)) return null;
                    if (!ArgReader.TryGetDate(parsed, "d1end", out DateTime d1end)) return null;
                    if (!ArgReader.TryGetDate(parsed, "d2st", out DateTime d2st)) return null;
                    if (!ArgReader.TryGetDate(parsed, "d2end", out DateTime d2end)) return null;
                    return new Task2(d1st, d1end, d2st, d2end);
                case 3:
                    if (!ArgReader.TryGetStr(parsed, "s1", out string s1)) return null;
                    if (!ArgReader.TryGetStr(parsed, "s2", out string s2)) return null;
                    return new Task3(s1, s2);
                default:
                    CmdOutput.CmdWriteLine("ERROR: Unknown task.");
                    return null;
            }
        }
    }
}
