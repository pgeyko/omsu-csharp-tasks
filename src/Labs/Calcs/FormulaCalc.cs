using Labs.Exceptions;

namespace Labs.Calcs
{
    public static class FormulaCalc
    {
        public static double Calculate(int x, int y, int z)
        {
            if (z == 0)
                throw new ValidationException("Z must not be zero (division by zero in X % Z).");
            if (y < 0)
                throw new ValidationException("Y must not be negative (sqrt of negative number).");
            return x % z + Math.Sqrt(y);
        }
    }
}
