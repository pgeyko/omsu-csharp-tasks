using System.Text.RegularExpressions;
using Labs.Utils;

namespace Labs.Tasks
{
    public class Task3
    {
        public static void Run(Dictionary<string, string?> parsed)
        {
            if (!ArgReader.TryGetStr(parsed, "s1", out string sOne))
                return;
            if (!ArgReader.TryGetStr(parsed, "s2", out string sTwo))
                return;

            Console.WriteLine($"EQUAL: {sOne == sTwo}".ToUpper());
            Console.WriteLine($"NORMALIZED: {Normalise(sOne) == Normalise(sTwo)}".ToUpper());
            Console.WriteLine($"REVERSED: {sOne == Reverse(sTwo)}".ToUpper());
            Console.WriteLine($"S1_EMAIL: {IsEmail(sOne)}".ToUpper());
            Console.WriteLine($"S1_PHONE: {IsPhone(sOne)}".ToUpper());
            Console.WriteLine($"S1_IP: {IsIp(sOne)}".ToUpper());
            Console.WriteLine($"S2_EMAIL: {IsEmail(sTwo)}".ToUpper());
            Console.WriteLine($"S2_PHONE: {IsPhone(sTwo)}".ToUpper());
            Console.WriteLine($"S2_IP: {IsIp(sTwo)}".ToUpper());



        }
        private static string Normalise(string value)
        {
            string lower = value.ToLowerInvariant();
            string trim = lower.Trim();
            return Regex.Replace(trim, @"\s{2,}", " ");
        }
        private static string Reverse(string value)
        {
            return new string(value.Reverse().ToArray());
        }
        private static bool IsEmail(string value)
        {
            return Regex.IsMatch(value, @"^[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+$");
        }
        private static bool IsPhone(string value)
        {
            return Regex.IsMatch(value, @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$$");
        }
        private static bool IsIp(string value)
        {
            return Regex.IsMatch(value, @"^(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$");
        }
    }
}
