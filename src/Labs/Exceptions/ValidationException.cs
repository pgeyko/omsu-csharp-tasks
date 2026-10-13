using System.ComponentModel.DataAnnotations;

namespace Labs.Exceptions
{
    public class ValidationException(string message) : Exception(message)
    {
    }
}
