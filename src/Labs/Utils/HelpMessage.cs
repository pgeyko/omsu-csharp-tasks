using Labs.InputOutput;

namespace Labs.Utils
{
    public class HelpMessage
    {
        public static void PrintHelp()
        {
            CmdOutput.CmdWriteLine("HELP:");
            CmdOutput.CmdWriteLine("    --task - task number");
            CmdOutput.CmdWriteLine("    -x - value of X");
            CmdOutput.CmdWriteLine("    -y - value of Y");
            CmdOutput.CmdWriteLine("    -z - value of Z");
            CmdOutput.CmdWriteLine("    -d1st - start of the first date segment (DD.MM.YYYY)");
            CmdOutput.CmdWriteLine("    -d1end - end of the first date segment (DD.MM.YYYY)");
            CmdOutput.CmdWriteLine("    -d2st - start of the second date segment (DD.MM.YYYY)");
            CmdOutput.CmdWriteLine("    -d2end - end of the second date segment (DD.MM.YYYY)");
        }
    }
}
