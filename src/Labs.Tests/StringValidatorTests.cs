using Labs.Calcs;
using Labs.Exceptions;

namespace Labs.Tests
{
    public class StringValidatorTests
    {
        [TestCase("abc", "abc")]
        public void ValidateEqual_EqualStrings_DoesNotThrow(string s1, string s2)
        {
            Assert.DoesNotThrow(() => StringValidator.ValidateEqual(s1, s2));
        }

        [TestCase("Hello   world", "hello world")]
        public void ValidateNormalized_NormalizedStrings_DoesNotThrow(string s1, string s2)
        {
            Assert.DoesNotThrow(() => StringValidator.ValidateNormalized(s1, s2));
        }

        [TestCase("abc", "cba")]
        public void ValidateReversed_ReversedStrings_DoesNotThrow(string s1, string s2)
        {
            Assert.DoesNotThrow(() => StringValidator.ValidateReversed(s1, s2));
        }

        [TestCase("pavel_geiko@invalid.com")]
        public void ValidateEmail_ValidEmail_DoesNotThrow(string s)
        {
            Assert.DoesNotThrow(() => StringValidator.ValidateEmail(s));
        }

        [TestCase("123-456-7890")]
        public void ValidatePhone_ValidPhone_DoesNotThrow(string s)
        {
            Assert.DoesNotThrow(() => StringValidator.ValidatePhone(s));
        }

        [TestCase("192.168.1.1")]
        public void ValidateIp_ValidIp_DoesNotThrow(string s)
        {
            Assert.DoesNotThrow(() => StringValidator.ValidateIp(s));
        }
        // Exceptions
        [TestCase("abc", "abcd")]
        public void ValidateEqual_EqualStrings_ThrowsValidationException(string s1, string s2)
        {
            Assert.Throws<ValidationException>(() => StringValidator.ValidateEqual(s1, s2));
        }

        [TestCase("Abc", "abcD")]
        public void ValidateNormalized_NormalizedStrings_ThrowsValidationException(string s1, string s2)
        {
            Assert.Throws<ValidationException>(() => StringValidator.ValidateNormalized(s1, s2));
        }

        [TestCase("abc", "abcd")]
        public void ValidateReversed_ReversedStrings_ThrowsValidationException(string s1, string s2)
        {
            Assert.Throws<ValidationException>(() => StringValidator.ValidateReversed(s1, s2));
        }

        [TestCase("abc")]
        public void ValidateEmail_InvalidEmail_ThrowsValidationException(string s)
        {
            Assert.Throws<ValidationException>(() => StringValidator.ValidateEmail(s));
        }

        [TestCase("abc")]
        public void ValidatePhone_InvalidPhone_ThrowsValidationException(string s)
        {
            Assert.Throws<ValidationException>(() => StringValidator.ValidatePhone(s));
        }

        [TestCase("abc")]
        public void ValidateIp_InvalidIp_ThrowsValidationException(string s)
        {
            Assert.Throws<ValidationException>(() => StringValidator.ValidateIp(s));
        }
    }
}
