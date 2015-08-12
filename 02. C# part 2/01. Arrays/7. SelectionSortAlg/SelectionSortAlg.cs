using System;

class SelectionSortAlg
{
    static void Main()
    {
        /*
         Problem 7. Selection sort
            Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
            Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
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

        for (int i = 0; i < lenOfArr; i++)
        {
            for (int j = i; j < lenOfArr; j++)
            {
                if(arr[i] > arr[j])
                {
                    int swap = arr[j];
                    arr[j] = arr[i];
                    arr[i] = swap;
                }
            }
        }

        foreach (int element in arr)
        {
            Console.Write(element + ",");
        }

        Console.WriteLine();
    }
}
