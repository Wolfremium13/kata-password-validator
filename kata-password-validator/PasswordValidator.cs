using System.Linq;

namespace kata_password_validator
{
    public class PasswordValidator

    {
        public static bool IsValid(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            if (!password.Contains('_'))
            {
                return false;
            }
            return true;
        }
    }
}