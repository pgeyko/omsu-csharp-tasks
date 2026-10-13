using Labs.Calcs;
using Labs.InputOutput;
using Labs.Utils;

namespace Labs.Tasks
{
    public sealed class Task3 : BaseTask
    {
        private readonly string s1, s2;
        public Task3(string s1, string s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }
        public override int Number => 3;
        public override string Description => "Working with strings";
        public override void Execute()
        {
            CmdOutput.CmdWriteLine($"EQUAL: {ValidationHelper.TryCheck(() => StringValidator.ValidateEqual(s1, s2))}".ToUpper());
            CmdOutput.CmdWriteLine($"NORMALIZED: {ValidationHelper.TryCheck(() => StringValidator.ValidateNormalized(s1, s2))}".ToUpper());
            CmdOutput.CmdWriteLine($"REVERSED: {ValidationHelper.TryCheck(() => StringValidator.ValidateReversed(s1, s2))}".ToUpper());
            CmdOutput.CmdWriteLine($"S1_EMAIL: {ValidationHelper.TryCheck(() => StringValidator.ValidateEmail(s1))}".ToUpper());
            CmdOutput.CmdWriteLine($"S1_PHONE: {ValidationHelper.TryCheck(() => StringValidator.ValidatePhone(s1))}".ToUpper());
            CmdOutput.CmdWriteLine($"S1_IP: {ValidationHelper.TryCheck(() => StringValidator.ValidateIp(s1))}".ToUpper());
            CmdOutput.CmdWriteLine($"S2_EMAIL: {ValidationHelper.TryCheck(() => StringValidator.ValidateEmail(s2))}".ToUpper());
            CmdOutput.CmdWriteLine($"S2_PHONE: {ValidationHelper.TryCheck(() => StringValidator.ValidatePhone(s2))}".ToUpper());
            CmdOutput.CmdWriteLine($"S2_IP: {ValidationHelper.TryCheck(() => StringValidator.ValidateIp(s2))}".ToUpper());
        }
    }
}
