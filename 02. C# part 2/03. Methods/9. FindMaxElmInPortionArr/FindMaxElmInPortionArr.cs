using System;

class FindMaxElmInPortionArr
{
    static void Main()
    {
        /*
         Problem 9. Sorting array
            Write a method that return the maximal element in a portion of array of integers starting at given index.
            Using it write another method that sorts an array in ascending / descending order.
         */
        int[] array = { 2, 4, 6, 6, 5 };
        int index = 0;

        Console.Write("Insert index of array: ");
        string text = Console.ReadLine();
        int.TryParse(text, out index);

        if (index < 0)
        {
            index = 0;
        }
        else if (index > array.Length - 1)
        {
            index = array.Length - 1;
        }

        FindMaxElemInArr(array, index);
        SortArrInAscendingOrder(array);
        SortArrInDescendingOrder(array);
    }

    static void FindMaxElemInArr(int[] arr, int position)
    {
        for (int i = position; i < arr.Length - 1; i++)
        {
            if(arr[position] < arr[i + 1])
            {
                int swap = arr[position];
                arr[position] = arr[i + 1];
                arr[i + 1] = swap;
            }
        }
        Console.WriteLine(arr[position]);
    }

    static void SortArrInDescendingOrder(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[i] < arr[j + 1])
                {
                    int swap = arr[j + 1];
                    arr[j + 1] = arr[i];
                    arr[i] = swap;
                }
            }
        }
        
        foreach(int elem in arr)
        {
            Console.Write("{0}, ", elem);
        }
        Console.WriteLine();
    }

    static void SortArrInAscendingOrder(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[i] > arr[j + 1])
                {
                    int swap = arr[j + 1];
                    arr[j + 1] = arr[i];
                    arr[i] = swap;
                }
            }
        }

        foreach (int elem in arr)
        {
            Console.Write("{0}, ", elem);
        }
        Console.WriteLine();
    }
}
