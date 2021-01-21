using Day_2.Models;

namespace Day_2.Services
{
    public class Part2PasswordValidator : IPasswordValidator
    {
        public bool Validate(string input)
        {
            var parsedPassword = new ParsedPassword(input);

            var passesPasswordPolicyPerfectly = 
                parsedPassword.Password[parsedPassword.LowerBound - 1] == parsedPassword.Character ^ 
                parsedPassword.Password[parsedPassword.UpperBound - 1] == parsedPassword.Character;

            return passesPasswordPolicyPerfectly;
        }
    }
}
