using Labs.Tasks;
using Labs.Exceptions;

namespace Labs.Tests
{
    public class Task2Tests
    {
        [Test]
        public void Task2_Execute_ValidInput_PrintsResult()
        {
            var sw = new StringWriter();
            var old = Console.Out;
            try
            {
                Console.SetOut(sw);
                var d1st = new DateTime(2020, 1, 1);
                var d1end = new DateTime(2020, 1, 5);
                var d2st = new DateTime(2020, 1, 1);
                var d2end = new DateTime(2020, 1, 5);

                new Task2(d1st, d1end, d2st, d2end).Execute();
            }
            finally
            {
                Console.SetOut(old);
            }
            string[] lines = sw.ToString().Split(["\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
            Assert.That(lines.Length, Is.EqualTo(2));
            Assert.That(lines[0], Is.EqualTo("DAYS: 5"));
            Assert.That(lines[1], Is.EqualTo("RESULT: 4.000"));
        }

        [Test]
        public void Task2_Execute_N36525_ThrowsValidationException()
        {
            var d1st = new DateTime(1900, 1, 1);
            var d1end = new DateTime(2000, 1, 1);
            var d2st = new DateTime(1900, 1, 1);
            var d2end = new DateTime(2000, 1, 1);

            Assert.Throws<ValidationException>(() => new Task2(d1st, d1end, d2st, d2end).Execute());
        }
    }
}
