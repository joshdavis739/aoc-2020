using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_4.Validators.Concretes
{
    public class EyeColorValidator : IFieldTypeValidator
    {
        public bool IsValid(string input)
        {
            return GetEyeColors().Contains(input);
        }

        public static IEnumerable<string> GetEyeColors()
        {
            yield return "amb";
            yield return "blu";
            yield return "brn";
            yield return "gry";
            yield return "grn";
            yield return "hzl";
            yield return "oth";
        }
    }
}
