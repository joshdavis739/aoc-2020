using System;
using System.Collections.Generic;
using System.Text;
using Day_4.Enums;
using Day_4.Validators;
using Day_4.Validators.Concretes;

namespace Day_4.Lookups
{
    public class FieldTypeValidatorLookup
    {
        public static Dictionary<PassportField, IFieldTypeValidator> GetLookup()
        {
            var dictionary = new Dictionary<PassportField, IFieldTypeValidator>
            {
                { PassportField.BirthYear, new BirthYearValidator() },
                { PassportField.ExpirationYear, new ExpirationYearValidator() },
                { PassportField.EyeColor, new EyeColorValidator() },
                { PassportField.HairColor, new HairColorValidator() },
                { PassportField.Height, new HeightValidator() },
                { PassportField.IssueYear, new IssueYearValidator() },
                { PassportField.PassportId, new PassportIdValidator() },
                { PassportField.CountryId, new CountryIdValidator() }
            };

            return dictionary;
        }
    }
}
