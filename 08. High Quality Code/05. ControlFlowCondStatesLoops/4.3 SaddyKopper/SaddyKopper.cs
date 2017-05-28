namespace _4._3_SaddyKopper
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class SaddyKopper
    {
        public const int MAX_TRANSFORMATION = 10;

        public static void Main(string[] args)
        {
            string number = Console.ReadLine();

            PrintAlgorithmResult(number);
        }

        private static void PrintAlgorithmResult(string number)
        {
            long sumEvenDigits = 0;
            BigInteger productOfAllSum = new BigInteger();
            productOfAllSum = 1;
            int transformationCount = 0;
            string currNum = number;
            List<long> sums = new List<long>();
            while (true)
            {
                if (transformationCount == MAX_TRANSFORMATION)
                {
                    Console.WriteLine(productOfAllSum);
                    break;
                }

                if (productOfAllSum < MAX_TRANSFORMATION && currNum.Length == 1)
                {
                    Console.WriteLine(transformationCount);
                    Console.WriteLine(productOfAllSum);
                    break;
                }

                number = currNum;

                if (number.Length > 1)
                {
                    number = currNum.Remove(number.Length - 1);
                }

                for (int i = 0; i < number.Length; i++)
                {
                    long digit = number[i] - '0';

                    if (i % 2 == 0)
                    {
                        sumEvenDigits += digit;
                    }
                }

                sums.Add(sumEvenDigits);
                sumEvenDigits = 0;
                currNum = number;

                if (currNum.Length == 1)
                {
                    foreach (long sum in sums)
                    {
                        productOfAllSum *= sum;
                    }

                    sums.Clear();
                    currNum = productOfAllSum.ToString();
                    transformationCount++;

                    if (productOfAllSum > MAX_TRANSFORMATION - 1 && transformationCount < MAX_TRANSFORMATION)
                    {
                        productOfAllSum = 1;
                    }
                }
            }
        }
    }
}
