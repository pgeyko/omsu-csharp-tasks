namespace Labs.Utils
{
    public class ArgsValidator
    {
        public static bool TryGetTask(Dictionary<string, string?> parsed, out int task, int NumTask)
        {
            if (!int.TryParse(parsed.GetValueOrDefault("task"), out task))
            {
                Console.WriteLine("ERROR: Task number must be integer number.");
                return false;
            }
            if (task < 1)
            {
                Console.WriteLine("ERROR: Unknown task. Task number cannot be less than 1.");
                return false;
            }
            if (task > NumTask)
            {
                Console.WriteLine($"ERROR: Unknown task. Task number must not exceed {NumTask}.");
                return false;
            }
            return true;
        }
    }
}
