namespace Labs.Utils
{
    public class ArgsValidator
    {
        public static bool TryValidate(Dictionary<string, string?> parsed, out int task, out int x, out int y, out int z, int NumTask)
        {
            task = x = y = z = 0;
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
            if (!int.TryParse(parsed.GetValueOrDefault("x"), out x))
            {
                Console.WriteLine("ERROR: Value X must be an integer.");
                return false;
            }
            if (!int.TryParse(parsed.GetValueOrDefault("y"), out y))
            {
                Console.WriteLine("ERROR: Y must be integer number.");
                return false;
            }
            if (!int.TryParse(parsed.GetValueOrDefault("z"), out z))
            {
                Console.WriteLine("ERROR: Z must be integer number.");
                return false;
            }

            return true;
        }
    }
}
