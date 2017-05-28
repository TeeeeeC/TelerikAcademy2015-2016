namespace PrintAllSubsetsOfKStrings
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static string[] result;

        public static void Main()
        {
            var arr = new string[] {"test", "rock", "fun"};
            var number = 2;
            result = new string[number];

            PrintAllSubsets(0, 0, number, arr);
        }

        private static void PrintAllSubsets(int index, int start, int end, string[] arr)
        {
            if (index == end)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            for (int i = start; i < arr.Length; i++)
            {
                result[index] = arr[i];
                PrintAllSubsets(index + 1, i + 1, end, arr);
            }
        }
    }
}
