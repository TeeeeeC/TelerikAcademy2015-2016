using System;

class AllocateArray
{
    static void Main()
    {
        /*
         Problem 1. Allocate array
            Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
            Print the obtained array on the console.
         */
        int[] arr = new int[20];
        int num = 0;

        for (int i = 0; i < 20; i++)
        {
            string line = Console.ReadLine();
            int.TryParse(line, out num);
            arr[i] = num;
        }

        for (int index = 0; index < 20; index++)
        {
            arr[index] = arr[index] * 5;
        }

        foreach(int number in arr)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

