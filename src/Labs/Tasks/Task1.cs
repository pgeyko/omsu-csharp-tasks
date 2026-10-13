using System.Globalization;
using Labs.Calcs;
using Labs.InputOutput;

namespace Labs.Tasks
{
    public sealed class Task1 : BaseTask
    {
        private readonly int x, y, z;

        public Task1(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override int Number => 1;
        public override string Description => "X % Z + sqrt(Y)";
        public override void Execute()
        {
            double r = FormulaCalc.Calculate(x, y, z);
            CmdOutput.CmdWriteLine(string.Format(CultureInfo.InvariantCulture, "RESULT: {0:F3}", r));
        }
    }
}
