using System;

namespace Labs.Tasks
{
    public class Task1
    {
        public static void Run(int x, int y, int z)
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
