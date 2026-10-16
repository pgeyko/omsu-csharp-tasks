using Labs.Calcs;
using Labs.Exceptions;

namespace Labs.Tests
{
    public class FormulaCalcTests
    {
        [Test]
        public void Calculate_X7_Y4_Z3_ReturnsThree()
        {
            int x = 7, y = 4, z = 3;
            double expectedResult = 3.000;
            double actualResult = FormulaCalc.Calculate(x, y, z);
            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.001));
        }
        [TestCase(5, 2, 3, 3.414)]
        [TestCase(7, 4, 3, 3.000)]
        public void Calculate_ValidInput_ReturnExpectedResult(int x, int y, int z, double expectedResult)
        {
            double actualResult = FormulaCalc.Calculate(x, y, z);

            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(7, -9, 3)]
        [TestCase(3, -4, 5)]
        public void Calculate_InvalidInput_Y_ThrowsValidationException(int x, int y, int z)
        {
            var ex = Assert.Throws<ValidationException>(() => FormulaCalc.Calculate(x, y, z));

            Assert.That(ex.Message, Does.Contain("Y must not be negative (sqrt of negative number)"));
        }

        [TestCase(7, 4, 0)]
        [TestCase(1, 2, 0)]
        public void Calculate_InvalidInput_Z_ThrowsValidationException(int x, int y, int z)
        {
            var ex = Assert.Throws<ValidationException>(()=> FormulaCalc.Calculate(x, y, z));

            Assert.That(ex.Message, Does.Contain("Z must not be zero (division by zero in X % Z)"));
        }

    }
}
