namespace Labs.Calcs
{
    public class PowerOfTwo
    {
        public static long CalculateMaxPowerOfTwo(long n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return 2 * CalculateMaxPowerOfTwo(n / 2);
        }
    }
}
