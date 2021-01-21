using Day_4.Enums;

namespace Day_4.Validators.Concretes
{
    public class HeightValidator : IFieldTypeValidator
    {
        public bool IsValid(string input)
        {
            if (input.Length < 3)
            {
                return false;
            }

            var measurement = input.Substring(input.Length - 2);
            var value = input.Substring(0, input.Length - 2);

            if (!HeightFieldTypeValidatorLookup.GetLookup().TryGetValue(measurement, out var measurementType))
            {
                return false;
            }

            var validator = new HeightFieldTypeValidatorLookup().GetValidatorLookup()[measurementType];

            return validator.IsValid(value);
        }
    }
}
