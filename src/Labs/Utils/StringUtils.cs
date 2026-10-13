using System.Text.RegularExpressions;

namespace Labs.Utils
{
    public static class StringUtils
    {
        public static string Normalise(string value)
        {
            string lower = value.ToLowerInvariant();
            string trim = lower.Trim();
            return Regex.Replace(trim, @"\s{2,}", " ");
        }
        public static string Reverse(string value)
        {
            return new string(value.Reverse().ToArray());
        }
    }
}
