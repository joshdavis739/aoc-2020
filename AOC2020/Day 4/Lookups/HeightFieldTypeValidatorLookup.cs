using System;
using System.Collections.Generic;
using System.Text;
using Day_4.Validators;
using Day_4.Validators.Abstracts;
using Day_4.Validators.Concretes;

namespace Day_4.Enums
{
    public class HeightFieldTypeValidatorLookup
    {
        public static Dictionary<string, HeightFieldType> GetLookup()
        {
            var dictionary = new Dictionary<string, HeightFieldType>
            {
                { "cm", HeightFieldType.Centimeters },
                { "in", HeightFieldType.Inches }
            };

            return dictionary;
        }

        public Dictionary<HeightFieldType, AHeightFieldTypeValidator> GetValidatorLookup()
        {
            var dictionary = new Dictionary<HeightFieldType, AHeightFieldTypeValidator>
            {
                { HeightFieldType.Centimeters, new CentimeterHeightValidator() },
                { HeightFieldType.Inches, new InchHeightValidator() }
            };

            return dictionary;
        }
    }
}
