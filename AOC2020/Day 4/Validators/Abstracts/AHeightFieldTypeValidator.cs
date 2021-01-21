using Day_4.Enums;

namespace Day_4.Validators.Abstracts
{
    public abstract class AHeightFieldTypeValidator : IFieldTypeValidator
    {
        protected abstract int MaxValue { get; }
        protected abstract int MinValue { get; }
        protected abstract HeightFieldType HeightFieldType { get; }

        public bool IsValid(string input)
        {
            return int.TryParse(input, out var numericInput) && numericInput >= MinValue && numericInput <= MaxValue;
        }
    }
}
