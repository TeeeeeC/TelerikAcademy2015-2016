using System;

class FindSeqOfGivenSum
{
    static void Main()
    {
        /*
         Problem 10. Find sum in array
            Write a program that finds in given array of integers a sequence of given sum S (if present).
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

        int sum = 0;
        Console.Write("Enter sum: ");
        text = Console.ReadLine();
        int.TryParse(text, out sum);
        
        int currSum = 0;
        int start = 0, end = 0;

        for (int i = 0; i < lenOfArr; i++)
        {
            for (int j = i; j < lenOfArr; j++)
            {
                currSum += arr[j];

                if (currSum == sum)
                {
                    start = i;
                    end = j;
                }
            }
            currSum = 0;
        }

        Console.Write("S = {0} -> ", sum);

        if (start != 0)
        {
            for (int k = start; k <= end; k++)
            {
                Console.Write(arr[k] + ",");
            }
        }
        else
        {
            Console.Write("There is no S = {0}!", sum);
        }

        Console.WriteLine();
    }
}
