using System;

class FindIndexByUseBinaryAlg
{
    static void Main()
    {
        /*
         Problem 11. Binary search
            Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
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

        int number = 0;
        Console.Write("Enter value for search: ");
        text = Console.ReadLine();
        int.TryParse(text, out number);

        int result = BinSearchAlg(arr, number, 0, lenOfArr);
    }

    static int BinSearchAlg(int[] arr, int value, int low, int high)
    {
        while (low <= high)
        {
            int center = (low + high) / 2;

            if (arr[center] == value)
            {
                Console.WriteLine("Index of entered value is {0}!", center);
                return center;
            }
            else if (arr[center] > value)
            {
                high = center - 1;
            }
            else if (arr[center] < value)
            {
                low = center + 1;
            }
        }

        Console.WriteLine("There is no such value in array!");
        return -1;
    }
}
