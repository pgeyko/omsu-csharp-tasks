using System.Text.RegularExpressions;
using Labs.Utils;
namespace Labs.Utils
{
    public static class StringValidator
    {
        public static void ValidateEqual(string s1, string s2)
        {
            if (s1 != s2)
            {
                throw new ValidationException("Strings are not equal.");
            }
        }
        public static void ValidateNormalized(string s1, string s2)
        {
            if (StringUtils.Normalise(s1) != StringUtils.Normalise(s2))
            {
                throw new ValidationException("Strings are not equal after normalization.");
            }
        }
        public static void ValidateReversed(string s1, string s2)
        {
            if (s1 != StringUtils.Reverse(s2))
            {
                throw new ValidationException("First string is not a reverse of the second.");
            }
        }
        public static void ValidateEmail(string s)
        {
            if (!Regex.IsMatch(s, @"^[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+$"))
            {
                throw new ValidationException("String is not an email.");
            }
        }
        public static void ValidatePhone(string s)
        {
            if (!Regex.IsMatch(s, @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$$"))
            {
                throw new ValidationException("String is not an phone.");
            }
        }
        public static void ValidateIp(string s)
        {
            if (!Regex.IsMatch(s, @"^(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$"))
            {
                throw new ValidationException("String is not an ip.");
            }
        }

    }
}
