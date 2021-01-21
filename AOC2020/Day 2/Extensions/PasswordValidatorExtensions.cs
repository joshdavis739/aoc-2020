using System.Linq;
using Day_2.Services;

namespace Day_2.Extensions
{
    public static class PasswordValidatorExtensions
    {
        public static int ValidPasswordCount(this string[] input, IPasswordValidator validator)
        {
            return input
                .Where(x => validator.Validate(x))
                .Count();
        }
    }
}
