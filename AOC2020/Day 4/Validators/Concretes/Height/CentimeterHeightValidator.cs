using Day_4.Enums;
using Day_4.Validators.Abstracts;

namespace Day_4.Validators.Concretes
{
    public class CentimeterHeightValidator : AHeightFieldTypeValidator
    {
        protected override int MaxValue => 193;

        protected override int MinValue => 150;

        protected override HeightFieldType HeightFieldType => HeightFieldType.Centimeters;
    }
}
