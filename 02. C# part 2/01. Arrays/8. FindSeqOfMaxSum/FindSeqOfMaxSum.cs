using System;

class FindSeqOfMaxSum
{
    static void Main()
    {
        /*
         Problem 8. Maximal sum
            Write a program that finds the sequence of maximal sum in given array.
            Can you do it with only one loop (with single scan through the elements of the array)?
         */
        int lenOfArr = 0;

        Console.Write("Lenght of array: ");
        string text = Console.ReadLine();
        int.TryParse(text, out lenOfArr);

        if (lenOfArr < 1)
        {
            lenOfArr = 10; //If user enter letter or negative number
        }

        int[] arr = new int[lenOfArr];
        int num = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter number of array: ");
            text = Console.ReadLine();
            int.TryParse(text, out num);
            arr[i] = num;
        }

        int currSum = 0, maxSum = 0;
        int len = 0, start = 0, bestStart = 0, bestEnd = 0;

        for (int i = 0; i < lenOfArr; i++)
        {
            for (int j = i; j < lenOfArr; j++)
            {
                currSum += arr[j];
                len++;
                if (len == 1)
                {
                    start = j;
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    bestStart = start;
                    bestEnd = j;
                }
            }
            currSum = 0;
            len = 0;
        }

        for (int p = bestStart; p <= bestEnd; p++)
        {
            Console.Write(arr[p] + ",");
        }
        Console.WriteLine();
    }
}
