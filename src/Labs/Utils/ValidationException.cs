using System.ComponentModel.DataAnnotations;

namespace Labs.Utils
{
    public class ValidationException(string message) : Exception(message)
    {
    }
}
