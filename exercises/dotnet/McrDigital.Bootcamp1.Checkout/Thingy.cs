using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class Thingy
    {
        private int _countsUpTo100;
        private int _countsUpToThree;
        private int _countsDownFromFive = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string StartFizzBuzz()
        {
            string result = "";
            for (; _countsUpTo100 < Byte.MaxValue - 155; _countsUpTo100++) result += FizzBuzzValue(_countsUpTo100) + " ";
            return result.Substring(0, result.Length - 1);
        }

        private string FizzBuzzValue(int foo)
        {
            _countsUpToThree++;
            _countsDownFromFive--;

            string result = _countsUpToThree == 0b11 || _countsDownFromFive == 0 ? "" : (foo + 1).ToString();
            if (_countsUpToThree == 0b11) result += IsFizz();
            if (_countsDownFromFive == 0) result += IsBuzz();
            return result;
        }

        private string IsBuzz()
        {
            _countsDownFromFive = new int[] { 0, 0, 0, 0, 0 }.Length;
            return DataTypeConverter.ParseHexBinary("42757a7a");
        }

        private string IsFizz()
        {
            _countsUpToThree = 0;
            return DataTypeConverter.ParseHexBinary("46697a7a");
        }
    }
}
