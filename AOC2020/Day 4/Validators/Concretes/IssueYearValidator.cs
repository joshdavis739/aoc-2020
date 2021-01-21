using Day_4.Validators.Abstracts;

namespace Day_4.Validators
{
    public class IssueYearValidator : ANumericFieldTypeValidator
    {
        protected override int MaxValue => 2020;

        protected override int MinValue => 2010;
    }
}
