namespace _02._2_SumOddDifference
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SumOddDifference
    {
        public static void Main(string[] args)
        {
            var numbers = ParseInput();
            var differenceNumbersResult = FindDifferenceBetweenTwoNumber(numbers);
            var sumOddDifference = FindSumOddDiffrences(differenceNumbersResult);

            Console.WriteLine(sumOddDifference);
        }

        private static long FindSumOddDiffrences(ICollection<long> differenceNumbersResult)
        {
            long sum = 0;
            foreach (var number in differenceNumbersResult)
            {
                if (number % 2 == 1)
                {
                    sum += number;
                }
            }

            return sum;
        }

        private static List<long> FindDifferenceBetweenTwoNumber(List<int> numbers)
        {
            int index = 1;
            var result = new List<long>();
            while (index < numbers.Count)
            {
                long currDifference = Math.Abs(numbers[index] - numbers[index - 1]);
                result.Add(currDifference);

                if (currDifference % 2 == 0)
                {
                    index += 2;
                }
                else
                {
                    index++;
                }
            }

            return result;
        }

        private static List<int> ParseInput()
        {
            string[] input = Console.ReadLine().Split(' ');

            List<int> numbers = new List<int>();
            foreach (var nums in input)
            {
                numbers.Add(int.Parse(nums));
            }

            return numbers;
        }
    }
}
