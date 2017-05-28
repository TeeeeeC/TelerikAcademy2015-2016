using System;

class CheckElemInArr
{
    static void Main()
    {
        /*
         Problem 5. Larger than neighbours
            Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
         */
        int[] arr = { 2, 3, 4, 3, 7, 5, 9, 1, 3, 2, 3, 1 };
        bool check = CheckElementAtPosition(arr, 10);
        Console.WriteLine(check);
    }

    static bool CheckElementAtPosition(int[] arr, int position)
    {
        if (position == 0 && arr[position] > arr[position + 1])
        {
            return true;
        }
        else if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
        {
            return true;
        }
        else if (arr[arr.Length - 1] > arr[arr.Length - 2])
        {
            return true;
        }

        return false;
    }
}
