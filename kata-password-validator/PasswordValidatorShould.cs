using Xunit;

namespace kata_password_validator
{
    public class PasswordValidatorShould
    {
        [Fact]
        public void validate_all_rules()
        {
            Assert.True(PasswordValidator.IsValid("helloWorld_1"));
        }
        
        [Fact]
        public void have_a_minimum_length()
        {
            Assert.False(PasswordValidator.IsValid("aA_1"));
        }

        [Fact]
        public void contain_a_lowercase_letter()
        {
            Assert.False(PasswordValidator.IsValid("HELLOWORLD_1"));
        }
        
        [Fact]
        public void contain_an_uppercase_letter()
        {
            Assert.False(PasswordValidator.IsValid("helloworld_1"));
        }
        
        [Fact]
        public void contain_a_number()
        {
            Assert.False(PasswordValidator.IsValid("helloWorld"));
        }
        
        [Fact]
        public void contain_a_under_score()
        {
            Assert.False(PasswordValidator.IsValid("helloWorld1"));
        }
    }
}