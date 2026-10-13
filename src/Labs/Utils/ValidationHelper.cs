using Labs.Exceptions;

namespace Labs.Utils
{
    public class ValidationHelper
    {
        public static bool TryCheck(Action action)
        {
            try
            {
                action();
                return true;
            }
            catch (ValidationException)
            {
                return false;
            }
        }
    }
}
