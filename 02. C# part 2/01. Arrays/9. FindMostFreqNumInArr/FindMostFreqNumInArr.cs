using System;
using System.Collections.Generic;

class FindMostFreqNumInArr
{
    static void Main()
    {
        /*
         Problem 9. Frequent number
            Write a program that finds the most frequent number in an array.
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

        Array.Sort(arr);

        int len = 1, bestLen = 1;
        int index = 0;

        for (int p = 0; p < lenOfArr - 1; p++)
        {
            if (arr[p] == arr[p + 1])
            {
                len++;

                if (len > bestLen)
                {
                    bestLen = len;
                    index = p;
                }
            }
            else
            {
                len = 1;
            }
        }

        List<int> list = new List<int>();

        // To check if it's exist two or more frequent number with equal frequent
        for (int p = 0; p < lenOfArr - 1; p++)
        {
            if (arr[p] == arr[p + 1])
            {
                len++;

                if (len == bestLen)
                {
                    bestLen = len;
                    int startIndex = p;
                    list.Add(startIndex);
                }
            }
            else
            {
                len = 1;
            }
        }

        if (bestLen > 1)
        {
            foreach (int item in list)
            {
                Console.WriteLine(arr[item] + "(" + bestLen + " times)");
            }
        }
        else
        {
            Console.WriteLine("There is no frequent number!");
        }
    }
}
