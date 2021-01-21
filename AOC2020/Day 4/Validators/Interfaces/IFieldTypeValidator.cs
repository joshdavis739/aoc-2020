using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4.Validators
{
    public interface IFieldTypeValidator
    {
        bool IsValid(string input);
    }
}
