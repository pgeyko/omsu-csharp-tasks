using System;
using Labs.Utils;
namespace Labs.Tasks
{
    public class Task1
    {
        public static void Run(Dictionary<string, string?> parsed)
        {
            if (!ArgReader.TryGetInt(parsed, "x", out int x)) return;
            if (!ArgReader.TryGetInt(parsed, "y", out int y)) return;
            if (!ArgReader.TryGetInt(parsed, "z", out int z)) return;

            Calculate(x, y, z);

        }
        private static void Calculate(int x, int y, int z)
        {
            if (z == 0)
            {
                Console.WriteLine("ERROR: Z must not be zero (division by zero in X % Z).");
                return;
            }
            if (y < 0)
            {
                Console.WriteLine("ERROR: Y must not be negative (sqrt of negative number).");
                return;
            }

            double result = x % z + Math.Sqrt(y);
            Console.WriteLine($"RESULT: {result:F3}");
        }
    }
}
