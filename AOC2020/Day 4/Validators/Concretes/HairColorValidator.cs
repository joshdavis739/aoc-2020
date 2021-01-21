using System;
using System.Linq;

namespace Day_4.Validators.Concretes
{
    public class HairColorValidator : IFieldTypeValidator
    {
        public bool IsValid(string input)
        {
            return input[0] == '#' && input.Length == 7 && !input.Substring(1).Any(x => !(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' }).Contains(x));
        }
    }
}
