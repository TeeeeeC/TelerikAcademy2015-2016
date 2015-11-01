using System;
using System.Diagnostics;
using System.Linq;

public class Assertions
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 1, "The array must consist atleast two elements!");
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[3]); // Test sorting empty array
        SelectionSort(new int[4]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0 && startIndex >= 0 && startIndex < arr.Length && endIndex > startIndex && endIndex < arr.Length, "Invalid startIndex and/or endIndex!");
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the left half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0 && startIndex >= 0 && startIndex < arr.Length && endIndex > startIndex && endIndex < arr.Length, "Invalid startIndex and/or endIndex!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        // minElementIndex *= int.MaxValue;
        Debug.Assert(minElementIndex < int.MaxValue, "The number cannot fill in Int32!");

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null || y != null, "X and y cannot be null!");
        T oldX = x;
        x = y;
        y = oldX;
    }
}
