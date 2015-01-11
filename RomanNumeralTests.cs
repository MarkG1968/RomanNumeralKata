using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should.Fluent;
using NFluent;

namespace MarkG1968.RomanNumeralKata
{
    public class RomanNumeralTests
    {
        private RomanNumeral sut;

        public RomanNumeralTests()
        {
            sut = new RomanNumeral();
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
            sut.ConvertFrom(1).Should().Equal("1");            
        }
    }
}
