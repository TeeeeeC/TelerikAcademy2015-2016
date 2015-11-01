using System;

class FindLargNumInArr
{
    static void Main()
    {
        /*
         Problem 4. Binary search
            Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() 
            finds the largest number in the array which is ≤ K.
         */
        int n = 0, k = 0;

        Console.Write("Size of array n: ");
        string text = Console.ReadLine();
        int.TryParse(text, out n);

        int[] arr = new int[n];

        Console.Write("Insert number K: ");
        text = Console.ReadLine();
        int.TryParse(text, out k);

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("Insert number from array: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int result = Array.BinarySearch(arr, 0, n, k);

        foreach(int elem in arr)
        {
            Console.Write(elem + " ");
        }

        Console.WriteLine();

        if (result > -1)
        {
            Console.WriteLine(arr[result]);
        }
        else
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i] < k)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }
    }
}
