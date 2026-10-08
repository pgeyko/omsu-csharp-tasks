namespace Labs.Utils
{
    public class CmdArgsParser
    {
        public static Dictionary<string, string?> Parse(string[] args)
        {
            Dictionary<string, string?> values = [];
            if (args.Length == 0)
                return values;

            for (int i = 0; i < args.Length; i++)
            {
                if (!IsKey(args[i])) continue;

                string key = args[i].TrimStart('-');
                string? value = null;

                if (i + 1 < args.Length && !IsKey(args[i + 1]))
                {
                    value = args[i + 1];
                    i++;
                }
                values[key] = value;
            }
            return values;
        }
        private static bool IsKey(string arg)
        {
            return arg.Length > 1 && arg[0] == '-' && !char.IsDigit(arg[1]);
        }
    }
}
