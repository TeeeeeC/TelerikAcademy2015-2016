using System;

class CheckFirstElemThanBiggerNeigh
{
    static void Main()
    {
        /*
         Problem 6. First larger than neighbours
            Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
            Use the method from the previous exercise.
         */
        int[] arr = { 1, 2, 3, 4, 7};
        int result = CheckElementAtPosition(arr);
        Console.WriteLine(result);
    }

    static int CheckElementAtPosition(int[] arr)
    {
        if (arr[0] > arr[1])
        {
            return 0;
        }

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return i;
            }
        }

        if (arr[arr.Length - 1] > arr[arr.Length - 2])
        {
            return arr.Length - 1;
        }

        return -1;
    }
}
