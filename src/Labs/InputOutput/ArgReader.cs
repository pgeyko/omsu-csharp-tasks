using System.Globalization;

namespace Labs.InputOutput
{
    public static class ArgReader
    {
        public static bool TryGetInt(Dictionary<string, string?> parsed, string key, out int value)
        {
            ArgumentNullException.ThrowIfNull(parsed);
            ArgumentNullException.ThrowIfNull(key);
            if (int.TryParse(parsed.GetValueOrDefault(key), out value))
            {
                return true;
            }
            CmdOutput.CmdWriteLine($"ERROR: Value {key.ToUpper()} must be an integer.");
            return false;
        }

        public static bool TryGetDate(Dictionary<string, string?> parsed, string key, out DateTime value)
        {
            ArgumentNullException.ThrowIfNull(parsed);
            ArgumentNullException.ThrowIfNull(key);
            string? text = parsed.GetValueOrDefault(key);
            if (text != null && DateTime.TryParseExact(text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out value))
            {
                return true;
            }
            value = default;
            CmdOutput.CmdWriteLine($"ERROR: Value {key.ToUpper()} must be a valid date in format DD.MM.YYYY.");
            return false;
        }
        public static bool TryGetStr(Dictionary<string, string?> parsed, string key, out string value)
        {
            ArgumentNullException.ThrowIfNull(parsed);
            ArgumentNullException.ThrowIfNull(key);
            if (parsed.TryGetValue(key, out string? rawValue) && !string.IsNullOrWhiteSpace(rawValue))
            {
                value = rawValue;
                return true;
            }

            value = string.Empty;
            CmdOutput.CmdWriteLine($"ERROR: Value {key.ToUpper()} must be specified.");
            return false;
        }
    }
}
