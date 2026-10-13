using System.Globalization;
using Labs.Calcs;
using Labs.InputOutput;

namespace Labs.Tasks
{
    public sealed class Task2 : BaseTask
    {
        private readonly DateTime d1st, d1end, d2st, d2end;

        public Task2(DateTime d1st, DateTime d1end, DateTime d2st, DateTime d2end)
        {
            this.d1st = d1st;
            this.d1end = d1end;
            this.d2st = d2st;
            this.d2end = d2end;
        }

        public override int Number => 2;
        public override string Description => "The highest power of two that does not exceed";

        public override void Execute()
        {
            int days = DateCalc.GetIntersectionDays(d1st, d1end, d2st, d2end);
            long p = PowerOfTwo.CalculateMaxPowerOfTwo(days);
            CmdOutput.CmdWriteLine($"DAYS: {days}");
            CmdOutput.CmdWriteLine(string.Format(CultureInfo.InvariantCulture, "RESULT: {0:F3}", (double)p));
        }
    }
}
