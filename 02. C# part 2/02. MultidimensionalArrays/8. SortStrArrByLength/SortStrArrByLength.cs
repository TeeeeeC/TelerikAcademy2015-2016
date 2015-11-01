using System;

class SortStrArrByLength
{
    static void Main()
    {
        /*
         Problem 5. Sort by string length
            You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
         */
        string[] arr = { "my", "name", "is", "two", "the", "i", "am", "twentyfive", "years", "old"};
        SortArrByLength(arr);
    }

    static void SortArrByLength(string[] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(0); j++)
            {
                string compare1 = arr[i];
                string compare2 = arr[j];

                if (compare1.Length > compare2.Length)
                {
                    string swap = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swap;
                }
            }
        }

        foreach(string elem in arr)
        {
            Console.Write("{0}, ", elem);
        }
        Console.WriteLine();
    }
}
