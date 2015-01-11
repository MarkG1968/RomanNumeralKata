using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkG1968.RomanNumeralKata
{
    class RomanNumeral
    {
        const int MinimumArabicValue = 1;
        const int MaximumArabicValue = 3000;

        internal String ConvertFrom(int arabicValue)
        {
            if (arabicValue < MinimumArabicValue)
            {
                throw new ArgumentOutOfRangeException("arabicValue", String.Format("Value must be at least {0}. Supplied value {1}", MinimumArabicValue, arabicValue));
            }

            if (arabicValue > MaximumArabicValue)
            {
                throw new ArgumentOutOfRangeException("arabicValue", String.Format("Value must be no more than {0}. Supplied value {1}", MaximumArabicValue, arabicValue));
            }

            return "1";
        }
    }
}
