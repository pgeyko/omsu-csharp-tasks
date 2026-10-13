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

            Console.WriteLine($"EQUAL: {Check(() => StringValidator.ValidateEqual(sOne, sTwo))}".ToUpper());
            Console.WriteLine($"NORMALIZED: {Check(() => StringValidator.ValidateNormalized(sOne, sTwo))}".ToUpper());
            Console.WriteLine($"REVERSED: {Check(() => StringValidator.ValidateReversed(sOne, sTwo))}".ToUpper());
            Console.WriteLine($"S1_EMAIL: {Check(() => StringValidator.ValidateEmail(sOne))}".ToUpper());
            Console.WriteLine($"S1_PHONE: {Check(() => StringValidator.ValidatePhone(sOne))}".ToUpper());
            Console.WriteLine($"S1_IP: {Check(() => StringValidator.ValidateIp(sOne))}".ToUpper());
            Console.WriteLine($"S2_EMAIL: {Check(() => StringValidator.ValidateEmail(sTwo))}".ToUpper());
            Console.WriteLine($"S2_PHONE: {Check(() => StringValidator.ValidatePhone(sTwo))}".ToUpper());
            Console.WriteLine($"S2_IP: {Check(() => StringValidator.ValidateIp(sTwo))}".ToUpper());

        }
        private static bool Check(Action action)
        {
            try
            {
                action();
                return true;
            }
            catch (ValidationException)
            {
                return false;
            }
        }

    }
}
