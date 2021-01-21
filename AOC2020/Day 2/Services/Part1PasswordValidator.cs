using System.Linq;
using Day_2.Models;

namespace Day_2.Services
{
    public class Part1PasswordValidator : IPasswordValidator
    {
        public bool Validate(string input)
        {
            var parsedPassword = new ParsedPassword(input);

            var countOfCharacters = parsedPassword.Password
                .ToCharArray()
                .Where(x => x == parsedPassword.Character)
                .Count();

            return countOfCharacters >= parsedPassword.LowerBound && countOfCharacters <= parsedPassword.UpperBound;
        }
    }
}
