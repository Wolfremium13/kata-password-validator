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
            return true;
        }
    }
}