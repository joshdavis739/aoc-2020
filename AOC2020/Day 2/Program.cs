using System;
using Day_2.Extensions;
using Day_2.Resources;
using Day_2.Services;

namespace Day_2
{
    public class Program
    {
        static void Main()
        {
            var fullInput = InputArrays.FullInput;

            var part1Validator = new Part1PasswordValidator();
            var part2Validator = new Part2PasswordValidator();

            var numberOfPassingPasswordsForPart1 = fullInput
                .ValidPasswordCount(part1Validator);

            var numberOfPassingPasswordsForPart2 = fullInput
                .ValidPasswordCount(part2Validator);

            Console.WriteLine(string.Format("Part 1 matches: {0}", numberOfPassingPasswordsForPart1));
            Console.WriteLine(string.Format("Part 2 matches: {0}", numberOfPassingPasswordsForPart2));

            Console.ReadKey();
        }
    }
}
