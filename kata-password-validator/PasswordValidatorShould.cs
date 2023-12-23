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
        
        [Fact]
        public void have_a_minimum_length()
        {
            Assert.False(PasswordValidator.IsValid("aA_1"));
        }
    }
}