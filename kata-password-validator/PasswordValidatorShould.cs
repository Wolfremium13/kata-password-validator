using Xunit;

namespace kata_password_validator
{
    public class PasswordValidatorShould
    {
        [Fact]
        public void validate_all_rules()
        {
            Assert.True(PasswordValidator.IsValid("holaMundo_1"));
        }
    }
}