namespace PrintAllPermutation
{
    using System;

    public class Startup
    {
        private static int[] arr;

        private static void Main()
        {
            Console.Write("Enter number N: ");
            int number = int.Parse(Console.ReadLine());

            arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                arr[i] = i + 1;
            }

            PrintPermunation(0, arr);
        }

        private static void PrintPermunation(int start, int[] arr)
        {
            if (start >= arr.Length)
            {
                Console.WriteLine("{0}", string.Join(" ", arr));
                return;
            }

            for (int i = start; i < arr.Length; i++)
            {
                Swap(start, i);
                PrintPermunation(start + 1, arr);
                Swap(start, i);
            }
        }

        private static void Swap(int firstIndex, int secondIndex)
        {
            int storedValue = arr[secondIndex];
            arr[secondIndex] = arr[firstIndex];
            arr[firstIndex] = storedValue;
        }
    }
}
