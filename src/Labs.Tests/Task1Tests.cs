using Labs.Tasks;
using Labs.Exceptions;

namespace Labs.Tests
{
    public class Task1Tests
    {
        [Test]
        public void Task1_Execute_ValidInput_PrintsResult()
        {
            var sw = new StringWriter();
            var old = Console.Out;
            try
            {
                Console.SetOut(sw);
                new Task1(7, 4, 3).Execute();
            }
            finally
            {
                Console.SetOut(old);
            }
            Assert.That(sw.ToString().Trim(), Is.EqualTo("RESULT: 3.000"));
        }

        [Test]
        public void Task1_Execute_ZeroZ_ThrowsValidationException()
        {
            Assert.Throws<ValidationException>(() => new Task1(7, 4, 0).Execute());
        }
    }
}
