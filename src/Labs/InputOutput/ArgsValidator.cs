using Labs.Exceptions;

namespace Labs.InputOutput
{
    public class ArgsValidator
    {
        public static bool TryGetTask(Dictionary<string, string?> parsed, out int task, int NumTask)
        {
            if (!int.TryParse(parsed.GetValueOrDefault("task"), out task))
            {
                throw new ValidationException("Task number must be integer number.");
            }
            if (task < 1)
            {
                throw new ValidationException("Unknown task. Task number cannot be less than 1.");
            }
            if (task > NumTask)
            {
                throw new ValidationException($"Unknown task. Task number must not exceed {NumTask}.");
            }
            return true;
        }
    }
}
