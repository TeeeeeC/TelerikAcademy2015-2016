using System;

class MaxSeqOfEqualElm
{
    static void Main()
    {
        /*
         Problem 4. Maximal sequence
            Write a program that finds the maximal sequence of equal elements in an array.
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

        int len = 0, bestLen = 0;
        int start = 0, bestStart = 0, bestEnd = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                len++;
                if (len == 1)
                {
                    start = i;
                }

                if (len > bestLen)
                {
                    bestStart = start;
                    bestEnd = i + 1;
                    bestLen = len;
                }
            }
            else
            {
                len = 0;
            }
        }

        if (bestStart != bestEnd)
        {
            for (int i = bestStart; i <= bestEnd; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }
        else
        {
            Console.WriteLine("There is no existing maximal sequence of equal elements in an array!");
        }
        Console.WriteLine();
    }
}
