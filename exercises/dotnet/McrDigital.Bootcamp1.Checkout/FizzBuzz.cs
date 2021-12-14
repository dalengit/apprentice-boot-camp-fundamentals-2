using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzz
    {
        private int _countsUpToThree;
        private int _countsDownFromFive = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string StartFizzBuzz()
        {
            var result = "";
            const int oneHundred = 100;

            for (int _countsUpTo100 = 0; _countsUpTo100 < oneHundred; _countsUpTo100++)
            {
                result += FizzBuzzValue(_countsUpTo100) + " ";
            }

            return result.Substring(0, result.Length - 1);
        }

        private string FizzBuzzValue(int currentNumber)
        {
            const int three = 0b11;

            _countsUpToThree++;
            _countsDownFromFive--;

            var isMultipleOfThree = _countsUpToThree == three;
            var isMultipleOfFive = _countsDownFromFive == 0;
            var result = NumberAsString(currentNumber, isMultipleOfThree, isMultipleOfFive);

            if (isMultipleOfThree)
            {
                result += Fizz();
            }

            if (isMultipleOfFive)
            {
                result += Buzz();
            }

            return result;
        }

        private string NumberAsString(int currentNumber, bool isMultipleOfThree, bool isMultipleOfFive)
        {
           return isMultipleOfThree ||  isMultipleOfFive ? "" : (currentNumber + 1).ToString();
        }

        private string Buzz()
        {
            const string buzz = "42757a7a";
            _countsDownFromFive = new int[] { 0, 0, 0, 0, 0 }.Length;
            return DataTypeConverter.ParseHexBinary(buzz);
        }

        private string Fizz()
        {
            const string fizz = "46697a7a";
            _countsUpToThree = 0;
            return DataTypeConverter.ParseHexBinary(fizz);
        }
    }
}
