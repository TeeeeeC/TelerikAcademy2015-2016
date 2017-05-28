using System;

class FindMaxKSum
{
    static void Main()
    {
        /*
         Problem 6. Maximal K sum
            Write a program that reads two integer numbers N and K and an array of N elements from the console.
            Find in the array those K elements that have maximal sum.
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

        int k = 0;
        Console.Write("Enter number k: ");
        text = Console.ReadLine();
        int.TryParse(text, out k);

        int currSum = 0, maxSum = 0;
        int start = 0, end = 0;

        for (int j = 0; j <= lenOfArr - k; j++)
        {
            for (int p = j; p < k + j; p++)
            {
                currSum += arr[p];

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    start = j;
                    end = p;
                }
            }
            currSum = 0;
        }

        for (int i = start; i <= end; i++)
        {
            Console.Write(arr[i] + ",");
        }

        Console.WriteLine();
    }
}
