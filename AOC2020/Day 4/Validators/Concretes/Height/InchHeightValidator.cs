using Day_4.Enums;
using Day_4.Validators.Abstracts;

namespace Day_4.Validators.Concretes
{
    public class InchHeightValidator : AHeightFieldTypeValidator
    {
        protected override int MaxValue => 76;

        protected override int MinValue => 59;

        protected override HeightFieldType HeightFieldType => HeightFieldType.Inches;
    }
}
