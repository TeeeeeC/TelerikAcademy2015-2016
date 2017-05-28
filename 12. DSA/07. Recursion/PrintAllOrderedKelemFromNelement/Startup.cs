using System;
using System.IO;

namespace PrintAllOrderedKelemFromNelement
{
    public class Startup
    {
        private static string[] result;

        private static void Main()
        {
            Console.Write("Enter number N: ");
            int numN = int.Parse(Console.ReadLine());

            Console.Write("Enter number K: ");
            int numK = int.Parse(Console.ReadLine());

            var set = new string[] {"hi", "a", "b"};
            result = new string[numK];
            Print(set, 0, numK);
        }

        private static void Print(string[] set, int index, int numK)
        {
            if (index == numK)
            {
                Console.WriteLine("{0}", string.Join(" ", result));
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                result[index] = set[i];
                Print(set, index + 1, numK);
            }
        }
    }
}
