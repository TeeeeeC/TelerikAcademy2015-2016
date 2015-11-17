namespace Deviders
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static int[] digits;
        private static HashSet<int> numbers;

        private static void Main()
        {
            var digitsCount = int.Parse(Console.ReadLine());
            digits = new int[digitsCount];
            numbers = new HashSet<int>();
            for (int i = 0; i < digitsCount; i++)
            {
                digits[i] = int.Parse(Console.ReadLine());
            }

            GeneratePermutation(0, 0);

            var answer = int.MaxValue;
            var dividerCount = int.MaxValue;
            foreach (var num in numbers)
            {
                var sqrt = Math.Sqrt(num);
                var currDividerCount = 0;
                for (int j = 2; j < sqrt; j++)
                {
                    if (num % j == 0)
                    {
                        currDividerCount++;
                    }
                }

                if (currDividerCount <= dividerCount)
                {
                    if (currDividerCount == dividerCount)
                    {
                        answer = Math.Min(answer, num);
                    }
                    else
                    {
                        answer = num;
                    }

                    dividerCount = currDividerCount;
                }
            }

            Console.WriteLine(answer);
        }

        private static void GeneratePermutation(int index, int start)
        {
            if (index == digits.Length)
            {
                numbers.Add(int.Parse(string.Join(string.Empty, digits)));
                return;
            }

            for (int i = start; i < digits.Length; i++)
            {
                Swap(i, start);
                GeneratePermutation(index + 1, start + 1);
                Swap(i, start);
            }
        }

        private static void Swap(int start, int end)
        {
            var storedValue = digits[start];
            digits[start] = digits[end];
            digits[end] = storedValue;
        }
    }
}
