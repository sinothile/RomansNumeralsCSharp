using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata.tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase(1 ,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        public void ConvertUnits_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            RomanNumerals numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertUnits(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(60, "LX")]
        [TestCase(70, "LXX")]
        [TestCase(80, "LXXX")]
        [TestCase(90, "XC")]
        public void ConvertTens_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertTens(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(100, "C")]
        [TestCase(200, "CC")]
        [TestCase(300, "CCC")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(600, "DC")]
        [TestCase(700, "DCC")]
        [TestCase(800, "DCCC")]
        [TestCase(900, "CM")]
        public void ConvertHundreds_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertHundreds(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(11, "XI")]
        [TestCase(19, "XIX")]
        [TestCase(21, "XXI")]
        [TestCase(29, "XXIX")]
        [TestCase(31, "XXXI")]
        [TestCase(39, "XXXIX")]
        [TestCase(41, "XLI")]
        [TestCase(49, "XLIX")]
        [TestCase(51, "LI")]
        [TestCase(59, "LIX")]
        [TestCase(61, "LXI")]
        [TestCase(69, "LXIX")]
        [TestCase(71, "LXXI")]
        [TestCase(79, "LXXIX")]
        [TestCase(81, "LXXXI")]
        [TestCase(89, "LXXXIX")]
        [TestCase(91, "XCI")]
        [TestCase(99, "XCIX")]
        public void ConvertNumbersCombinedByUnitsAndTens_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertNumbersCombinedByTensAndUnits(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(101, "CI")]
        [TestCase(102, "CII")]
        [TestCase(103, "CIII")]
        [TestCase(104, "CIV")]
        [TestCase(105, "CV")]
        [TestCase(106, "CVI")]
        [TestCase(107, "CVII")]
        [TestCase(108, "CVIII")]
        [TestCase(109, "CIX")]
        public void ConvertNumbersCombinedByHundredsAndUnits_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertNumbersCombinedByHundredsAndUnits(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(111, "CXI")]
        [TestCase(222, "CCXXII")]
        [TestCase(333, "CCCXXXIII")]
        [TestCase(444, "CDXLIV")]
        [TestCase(555, "DLV")]
        [TestCase(666, "DCLXVI")]
        [TestCase(777, "DCCLXXVII")]
        [TestCase(888, "DCCCLXXXVIII")]
        [TestCase(999, "CMXCIX")]
        public void ConvertNumbersCombinedByHundredsTensAndUnits_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertNumbersCombinedByHundredsTensAndUnits(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(1000, "M")]
        [TestCase(2000, "MM")]
        [TestCase(3000, "MMM")]
        public void ConvertThousands_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertThousands(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(1001, "MI")]
        [TestCase(1009, "MIX")]
        public void ConvertNumbersCombinedByThousandsAndUnits_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertNumbersCombinedByThousandsAndUnits(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(1011, "MXI")]
        [TestCase(1019, "MXIX")]
        public void ConvertNumbersCombinedByThousandsTensAndUnits_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertNumbersCombinedByThousandsTensAndUnits(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase(1999, "MCMXCIX")]
        [TestCase(2999, "MMCMXCIX")]
        public void ConvertNumbersCombinedByThousandsHundredsTensAndUnits_GivenANumber_ShouldReturnNumberInRomanNumerals(int number, string expected)
        {
            //Arrange
            var numberConverter = RomanNumeralsService();

            //Act
            var actual = numberConverter.ConvertNumbersCombinedByThousandsHundredsTensAndUnit(number);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        public RomanNumerals RomanNumeralsService()
        {
            return new RomanNumerals();
        }

    }
}
