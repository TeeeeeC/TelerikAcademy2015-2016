namespace PrintAllCombinationsWithoutDublicates
{
    using  System;

    public class Startup
    {
        private static void Main()
        {
            Console.Write("Enter number N: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("Enter number K: ");
            int numberK = int.Parse(Console.ReadLine());
            int[] arr = new int[numberK];

            PrintAllCombinationsWithDublicates(arr, 0, 1, numberN);

        }

        private static void PrintAllCombinationsWithDublicates(int[] arr, int index, int start, int end)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                arr[index] = i;
                PrintAllCombinationsWithDublicates(arr, index + 1, i + 1, end);
            }
        }
    }
}
