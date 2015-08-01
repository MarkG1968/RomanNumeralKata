using System;
using System.Text;

namespace MarkG1968.RomanNumeralKata
{
    class RomanNumeralConverter
    {
        const int MinimumArabicValue = 1;
        const int MaximumArabicValue = 3000;

        internal String ConvertFrom(int arabicValue)
        {
            AssertArabicValueInRange(arabicValue);

            StringBuilder valueInRomanNumerals = new StringBuilder();

            var residualArabicValue = arabicValue;

            while(residualArabicValue > 0)
            {
                RomanNumeral nextBiggestRomanNumeral = new RomanNumerals().FindBiggestRomanNumeralIn(residualArabicValue);

                valueInRomanNumerals.Append(nextBiggestRomanNumeral.romanNumeral);
                residualArabicValue -= nextBiggestRomanNumeral.arabicValue;
            }

            return valueInRomanNumerals.ToString();
        }

        private static void AssertArabicValueInRange(int arabicValue)
        {
            if (arabicValue < MinimumArabicValue)
            {
                throw new ArgumentOutOfRangeException("arabicValue", String.Format("Value must be at least {0}. Supplied value {1}", MinimumArabicValue, arabicValue));
            }

            if (arabicValue > MaximumArabicValue)
            {
                throw new ArgumentOutOfRangeException("arabicValue", String.Format("Value must be no more than {0}. Supplied value {1}", MaximumArabicValue, arabicValue));
            }
        }
    }

    class RomanNumerals
    {
        RomanNumeral[] romanNumerals = new[] {
                                        new RomanNumeral{arabicValue = 1000, romanNumeral = "M"},
                                        new RomanNumeral{arabicValue = 900, romanNumeral = "CM"},
                                        new RomanNumeral{arabicValue = 500, romanNumeral = "D"},
                                        new RomanNumeral{arabicValue = 400, romanNumeral = "CD"},
                                        new RomanNumeral{arabicValue = 100, romanNumeral = "C"},
                                        new RomanNumeral{arabicValue = 90, romanNumeral = "XC"},
                                        new RomanNumeral{arabicValue = 50, romanNumeral = "L"},
                                        new RomanNumeral{arabicValue = 40, romanNumeral = "XL"},
                                        new RomanNumeral{arabicValue = 10, romanNumeral = "X"},
                                        new RomanNumeral{arabicValue = 9, romanNumeral = "IX"},
                                        new RomanNumeral{arabicValue = 5, romanNumeral = "V"},
                                        new RomanNumeral{arabicValue = 4, romanNumeral = "IV"},
                                        new RomanNumeral{arabicValue = 1, romanNumeral = "I"}
                                    };

        public RomanNumeral FindBiggestRomanNumeralIn(int arabicValue)
        {
            RomanNumeral nextRomanNumeral = null;
            foreach (var romanNumeralMapping in romanNumerals)
            {
                if (arabicValue >= romanNumeralMapping.arabicValue)
                {
                    nextRomanNumeral = romanNumeralMapping;
                    break;
                }
            }

            return nextRomanNumeral;
        }
    }

    class RomanNumeral
    {
        public int arabicValue;
        public String romanNumeral;
    }
}
