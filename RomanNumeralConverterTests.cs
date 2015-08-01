using System;
using Should.Fluent;
using NFluent;
using MarkG1968.RomanNumeralKata.Support;

namespace MarkG1968.RomanNumeralKata
{
    public class RomanNumeralConverterTests
    {
        private RomanNumeralConverter sut;

        public RomanNumeralConverterTests()
        {
            sut = new RomanNumeralConverter();
        }

        public void ShouldNotConvertLessThanOne()
        {
            Check.ThatCode(() => sut.ConvertFrom(0)).Throws<ArgumentOutOfRangeException>();
        }

        public void ShouldNotConvertMoreThanThreeThousand()
        {
            Check.ThatCode(() => sut.ConvertFrom(3001)).Throws<ArgumentOutOfRangeException>();
        }

        public void ShouldConvertOne()
        {
            sut.ConvertFrom(1).Should().Equal("I");            
        }

        public void ShouldConvertTwo()
        {
            sut.ConvertFrom(2).Should().Equal("II");
        }

        public void ShouldConvertThree()
        {
            sut.ConvertFrom(3).Should().Equal("III");
        }

        public void ShouldConvertFour()
        {
            sut.ConvertFrom(4).Should().Equal("IV");
        }

        public void ShouldConvertFive()
        {
            sut.ConvertFrom(5).Should().Equal("V");
        }

        public void ShouldConvertSix()
        {
            sut.ConvertFrom(6).Should().Equal("VI");
        }

        public void ShouldConvertNine()
        {
            sut.ConvertFrom(9).Should().Equal("IX");
        }
        
        public void ShouldConvertTen()
        {
            sut.ConvertFrom(10).Should().Equal("X");
        }
 
        [TestInput(30, "XXX")]
        [TestInput(8, "VIII")]
        [TestInput(39, "XXXIX")]
        [TestInput(50, "L")]
        [TestInput(40, "XL")]
        [TestInput(49, "XLIX")]
        [TestInput(90, "XC")]
        [TestInput(100, "C")]
        [TestInput(337, "CCCXXXVII")]
        [TestInput(500, "D")]
        [TestInput(1415, "MCDXV")]
        [TestInput(1968, "MCMLXVIII")]
        [TestInput(2015, "MMXV")]
        public void ShouldConvertValue(int arabicValue, string romanNumeral)
        {
            sut.ConvertFrom(arabicValue).Should().Equal(romanNumeral);
        }
    }
}
