using Labs.Calcs;
using Labs.Exceptions;

namespace Labs.Tests
{
    public class PowerOfTwoTests
    {
        
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 4)]
        public void CalculateMaxPowerOfTwo_ValidInput_ReturnsExpectedPower(long n, long expected)
        {
            long actual = PowerOfTwo.CalculateMaxPowerOfTwo(n);
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
