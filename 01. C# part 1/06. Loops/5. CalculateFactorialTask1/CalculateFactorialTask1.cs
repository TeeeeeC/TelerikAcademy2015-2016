using System;

class CalculateFactorialTask1
{
    static void Main()
    {
        /*
         Problem 7. Calculate N! / (K! * (N-K)!)
            In combinatorics, the number of ways to choose k different members out of a group of n different elements 
            (also known as the number of combinations) is calculated by the following formula: formula For example, 
            there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
             Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
         */
        Console.Write("Number N: ");
        int numN = int.Parse(Console.ReadLine());

        Console.Write("Number K: ");
        int numK = int.Parse(Console.ReadLine());

        int maxNum = Math.Max(numK, numN);
        int minNum = Math.Min(numK, numN);

        float result = 1;
        int saveNminusKFac = maxNum - minNum;

        for (int i = maxNum; i > 1; i--)
        {
            result *= (float)i / (minNum * saveNminusKFac);

            if (minNum > 1)
            {
                minNum--;
            }

            if (saveNminusKFac > 1)
            {
                saveNminusKFac--;
            }
        }

        Console.WriteLine("n! / (k! * (n-k)!) = {0}", result);
    }
}

