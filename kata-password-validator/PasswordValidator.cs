using System.Linq;

namespace kata_password_validator
{
    public class PasswordValidator

    {
        public static bool IsValid(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit) &&
                   password.Contains('_');
        }
    }
}