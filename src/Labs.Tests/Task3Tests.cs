using Labs.Tasks;
using Labs.Exceptions;

namespace Labs.Tests
{
    public class Task3Tests
    {
        [Test]
        public void Task3_Execute_Valid_S1Phone_Input_PrintsResult()
        {
            var sw = new StringWriter();
            var old = Console.Out;
            try
            {
                Console.SetOut(sw);
                new Task3("123-456-7890", "abc").Execute();
            }
            finally
            {
                Console.SetOut(old);
            }
            string[] lines = sw.ToString().Split(["\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
            Assert.That(lines.Length, Is.EqualTo(9));
            Assert.That(lines[0], Is.EqualTo("EQUAL: FALSE"));
            Assert.That(lines[1], Is.EqualTo("NORMALIZED: FALSE"));
            Assert.That(lines[2], Is.EqualTo("REVERSED: FALSE"));
            Assert.That(lines[3], Is.EqualTo("S1_EMAIL: FALSE"));
            Assert.That(lines[4], Is.EqualTo("S1_PHONE: TRUE"));
            Assert.That(lines[5], Is.EqualTo("S1_IP: FALSE"));
            Assert.That(lines[6], Is.EqualTo("S2_EMAIL: FALSE"));
            Assert.That(lines[7], Is.EqualTo("S2_PHONE: FALSE"));
            Assert.That(lines[8], Is.EqualTo("S2_IP: FALSE"));
        }

        [Test]
        public void Task3_Execute_Valid_S1EmailAndS2Ip_Input_PrintsResult()
        {
            var sw = new StringWriter();
            var old = Console.Out;
            try
            {
                Console.SetOut(sw);
                new Task3("test@example.com", "192.168.0.1").Execute();
            }
            finally
            {
                Console.SetOut(old);
            }
            string[] lines = sw.ToString().Split(["\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
            Assert.That(lines.Length, Is.EqualTo(9));
            Assert.That(lines[0], Is.EqualTo("EQUAL: FALSE"));
            Assert.That(lines[1], Is.EqualTo("NORMALIZED: FALSE"));
            Assert.That(lines[2], Is.EqualTo("REVERSED: FALSE"));
            Assert.That(lines[3], Is.EqualTo("S1_EMAIL: TRUE"));
            Assert.That(lines[4], Is.EqualTo("S1_PHONE: FALSE"));
            Assert.That(lines[5], Is.EqualTo("S1_IP: FALSE"));
            Assert.That(lines[6], Is.EqualTo("S2_EMAIL: FALSE"));
            Assert.That(lines[7], Is.EqualTo("S2_PHONE: FALSE"));
            Assert.That(lines[8], Is.EqualTo("S2_IP: TRUE"));
        }
        
    }
}
