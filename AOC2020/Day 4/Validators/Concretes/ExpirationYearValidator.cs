using Day_4.Validators.Abstracts;

namespace Day_4.Validators.Concretes
{
    public class ExpirationYearValidator : ANumericFieldTypeValidator
    {
        protected override int MaxValue => 2030;

        protected override int MinValue => 2020;
    }
}
