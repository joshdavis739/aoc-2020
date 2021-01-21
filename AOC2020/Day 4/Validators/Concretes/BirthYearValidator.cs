using System;
using System.Collections.Generic;
using System.Text;
using Day_4.Validators.Abstracts;

namespace Day_4.Validators.Concretes
{
    public class BirthYearValidator : ANumericFieldTypeValidator
    {
        protected override int MaxValue => 2002;

        protected override int MinValue => 1920;
    }
}
