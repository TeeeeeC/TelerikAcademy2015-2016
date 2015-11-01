namespace _02._1_ConvertStringToNumberByGivenBaseCSharp2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ConvertStringToNumber
    {
        public const int BASE_NUMBER = 19;

        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            long number = ConvertTextToNumber(input, BASE_NUMBER);
            string numberAsString = ConvertNumberToWord(number, BASE_NUMBER);

            Console.WriteLine("{0} = {1}", numberAsString, number);
        }

        private static string ConvertNumberToWord(long number, int baseNumber)
        {
            string word = string.Empty;
            while (number > 0)
            {
                long remainder = number % baseNumber;
                word = (char)(remainder + 'a') + word;
                number /= baseNumber;
            }

            return word;
        }

        private static long ConvertTextToNumber(string[] words, int baseNumber)
        {
            long sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                var numbers = new List<int>();
                foreach (var letter in currentWord)
                {
                    numbers.Add(letter - 'a');
                }

                long currentSum = 0;
                int power = numbers.Count - 1;
                foreach (var num in numbers)
                {
                    var resultOfPowerFunction = (long)Math.Pow(baseNumber, power);
                    currentSum += num * resultOfPowerFunction;
                    power--;
                }

                sum += currentSum;
            }

            return sum;
        }
    }
}
