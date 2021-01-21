using System;
using System.Collections.Generic;
using System.Linq;
using Day_4.Enums;
using Day_4.Lookups;
using Day_4.Resources;

namespace Day_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            RunPart1();
            RunPart2();
            Console.ReadKey();
        }

        public static void RunPart1()
        {
            var validPassportCount = GetValidPassports().Count();

            Console.WriteLine(string.Format("Number of valid passports: {0}", validPassportCount));
        }

        public static void RunPart2()
        {
            var validPassportCount = GetValidPassports()
                .Where(x => x.All(y => FieldTypeValidatorLookup.GetLookup()[y.Key].IsValid(y.Value)))
                .Count();

            Console.WriteLine(string.Format("Number of valid passports: {0}", validPassportCount));
        }

        private static IEnumerable<IEnumerable<KeyValuePair<PassportField, string>>> GetValidPassports()
        {
            return Inputs.BigInput.Split("\r\n\r\n")
                .Select(x => x
                              .Split("\r\n")
                              .SelectMany(y => y.Split(" "))
                              .Select(y =>
                              {
                                  var fieldIdentifier = y.Substring(0, 3);
                                  var fieldType = PassportFieldLookup.GetLookup()[fieldIdentifier];
                                  var fieldValue = y.Substring(4);

                                  return new KeyValuePair<PassportField, string>(
                                      fieldType,
                                      fieldValue);
                              }))
                .Where(x => x.Count() == 8 || (x.Count() == 7 && !x.Any(y => y.Key == PassportField.CountryId)));
        }
    }
}
