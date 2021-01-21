namespace Day_4.Validators.Concretes
{
    public class PassportIdValidator : IFieldTypeValidator
    {
        public bool IsValid(string input)
        {
            return input.Length == 9 && int.TryParse(input, out var _);
        }
    }
}
