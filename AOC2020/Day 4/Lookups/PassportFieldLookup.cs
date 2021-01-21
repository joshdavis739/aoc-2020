using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4.Enums
{
    public static class PassportFieldLookup
    {
        public static Dictionary<string, PassportField> GetLookup()
        {
            var dictionary = new Dictionary<string, PassportField>
            {
                { "byr", PassportField.BirthYear },
                { "iyr", PassportField.IssueYear },
                { "eyr", PassportField.ExpirationYear },
                { "hgt", PassportField.Height },
                { "hcl", PassportField.HairColor },
                { "ecl", PassportField.EyeColor },
                { "pid", PassportField.PassportId },
                { "cid", PassportField.CountryId }
            };

            return dictionary;
        }
    }
}
