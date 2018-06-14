using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        string converter;
        public string ConvertUnits(int number)
        {
            string [] units = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            converter = units[number % 10];
            return converter;
        }
        public string ConvertTens(int number)
        {
            string [] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            converter = tens[number % 100 / 10];
            return converter;
        }
        public string ConvertHundreds(int number)
        {
            string [] hundreds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            converter = hundreds[(number % 1000) / 100];
            return converter;
        }
        public string ConvertThousands(int number)
        {
            string[] thousands = new string[] { "", "M", "MM", "MMM"};
            converter = thousands[(number % 10000) / 1000];
            return converter;
        }
        public string ConvertNumbersCombinedByTensAndUnits(int number)
        {
            converter = ConvertTens(number) + ConvertUnits(number);
            return converter;
        }
        public string ConvertNumbersCombinedByHundredsAndUnits(int number)
        {
            converter = ConvertHundreds(number) + ConvertUnits(number);
            return converter;
        }
        public string ConvertNumbersCombinedByHundredsTensAndUnits(int number)
        {
            converter = ConvertHundreds(number) + ConvertTens(number) + ConvertUnits(number);
            return converter;
        }
        public string ConvertNumbersCombinedByThousandsAndUnits(int number)
        {
            converter = ConvertThousands(number) + ConvertUnits(number);
            return converter;
        }
        public string ConvertNumbersCombinedByThousandsTensAndUnits(int number)
        {
            converter = ConvertThousands(number) + ConvertTens(number) + ConvertUnits(number);
            return converter;
        }
        public string ConvertNumbersCombinedByThousandsHundredsTensAndUnit(int number)
        {
            converter = ConvertThousands(number) + ConvertHundreds(number) + ConvertTens(number) + ConvertUnits(number);
            return converter;
        }
    }
}
