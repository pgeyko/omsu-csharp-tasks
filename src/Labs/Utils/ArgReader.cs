using System.Globalization;

namespace Labs.Utils
{
    public static class ArgReader
    {
        public static bool TryGetInt(Dictionary<string, string?> parsed, string key, out int value)
        {
            if (int.TryParse(parsed.GetValueOrDefault(key), out value))
            {
                return true;
            }
            Console.WriteLine($"ERROR: Value {key.ToUpper()} must be an integer.");
            return false;
        }

        public static bool TryGetDate(Dictionary<string, string?> parsed, string key, out DateTime value)
        {
            string? text = parsed.GetValueOrDefault(key);
            if (text != null && DateTime.TryParseExact(text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out value))
            {
                return true;
            }
            value = default;
            Console.WriteLine($"ERROR: Value {key.ToUpper()} must be a valid date in format DD.MM.YYYY.");
            return false;
        }
    }
}