namespace Day_4.Validators.Abstracts
{
    public abstract class ANumericFieldTypeValidator : IFieldTypeValidator
    {
        protected abstract int MaxValue { get; }
        protected abstract int MinValue { get; }

        public bool IsValid(string input)
        {
            return input.Length == 4 && int.TryParse(input, out var numericInput) && numericInput >= MinValue && numericInput <= MaxValue;
        }
    }
}
