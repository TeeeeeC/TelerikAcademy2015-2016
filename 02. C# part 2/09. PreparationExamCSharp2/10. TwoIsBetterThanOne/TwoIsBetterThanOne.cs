using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class TwoIsBetterThanOne
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        long numA = long.Parse(input[0]);
        long numB = long.Parse(input[1]);

        int countLuckyNums = FindLuckyNumbers(numA, numB);
    }

    private static int FindLuckyNumbers(long numA, long numB)
    {
        long maxBound = numB;
        int left = 0;

        var numbers = new List<long> { 3, 5 };

        int countLuckyNum = 0;
        while(left < numbers.Count)
        {
            int right = numbers.Count;
            for (int i = left; i < right; i++)
            {
                if (numbers[i] < maxBound)
                {
                    numbers.Add((numbers[i] * 10) + 3);
                    numbers.Add((numbers[i] * 10) + 5);
                }
                else
                {
                    break;
                }
            }
            left = right;
        }

        foreach(var num in numbers)
        {
            if(FindPalindromes(num) && num >= numA && num <= maxBound)
            {
                countLuckyNum++;
            }
        }

        return countLuckyNum;
    }

    private static bool FindPalindromes(long num)
    {
        string number = num.ToString();
        for (int i = 0; i < number.Length/2; i++)
        {
            if(number[i] != number[number.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
