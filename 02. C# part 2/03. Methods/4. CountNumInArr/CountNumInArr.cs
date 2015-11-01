using System;
class Program
{
    static void Main()
    {
        /*
         Problem 4. Appearance count
            Write a method that counts how many times given number appears in given array.
            Write a test program to check if the method is workings correctly.
         */
        int[] arr = {2, 3, 4, 3, 7, 5, 9, 1, 3, 2, 3, 1};
        CountNumInArr(arr, 3, 0);
    }

    static void CountNumInArr(int[] arr, int num, int count)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if (num == arr[i])
                count++;
        }
        Console.WriteLine("{0}->{1} times in array", num, count);
    }
}
