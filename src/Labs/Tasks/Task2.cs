using System.Globalization;
using Labs.Utils;

namespace Labs.Tasks
{
    public static class Task2
    {
        private const int MaxDaysLimit = 10000;
        public static void Run(Dictionary<string, string?> parsed)
        {
            if (!ArgReader.TryGetDate(parsed, "d1st", out DateTime firstStart))
                return;
            if (!ArgReader.TryGetDate(parsed, "d1end", out DateTime firstEnd))
                return;
            if (!ArgReader.TryGetDate(parsed, "d2st", out DateTime secondStart))
                return;
            if (!ArgReader.TryGetDate(parsed, "d2end", out DateTime secondEnd))
                return;

            if (firstEnd < firstStart)
            {
                Console.WriteLine("ERROR: End of the first segment must not be earlier than its start.");
                return;
            }
            if (secondEnd < secondStart)
            {
                Console.WriteLine("ERROR: End of the second segment must not be earlier than its start.");
                return;
            }

            var startIntersect = firstStart > secondStart ? firstStart : secondStart;
            var endIntersect = firstEnd < secondEnd ? firstEnd : secondEnd;
            int nDays;
            if (startIntersect > endIntersect)
            {
                nDays = 0;
                Console.WriteLine("ERROR: Cannot find power of two for intersection length 0.");
                return;
            }
            else
            {
                nDays = (endIntersect - startIntersect).Days + 1;
            }

            if (nDays > MaxDaysLimit)
            {
                Console.WriteLine("ERROR: Intersection length exceeds maximum allowed limit.");
                return;
            }
            if (nDays == 0)
            {
                Console.WriteLine("ERROR: Cannot find power of two for zero days.");
                return;
            }

            long nPowerOfTwo = CalculateMaxPowerOfTwo(nDays);

            Console.WriteLine($"DAYS: {nDays}");
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "RESULT: {0:F3}", (double)nPowerOfTwo));
        }

        private static long CalculateMaxPowerOfTwo(long n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return 2 * CalculateMaxPowerOfTwo(n / 2);
        }
    }
}
