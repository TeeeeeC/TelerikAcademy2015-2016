using System;

class PrintRanNumInRange
{
    static void Main()
    {
        /*
        Problem 11. Random Numbers in Given Range
            Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in 
            the range [min...max].
         */
        Console.Write("Number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Min: ");
        int numMin = int.Parse(Console.ReadLine());

        Console.Write("Max: ");
        int numMax = int.Parse(Console.ReadLine());

        int min = Math.Min(numMin, numMax);
        int max = Math.Max(numMin, numMax);

        Random rand = new Random();

        for (int i = 0; i < num; )
        {
            int result = rand.Next(max + 1);

            if (result >= min)
            {
                Console.Write("{0} ", result);
                i++;
            }     
        }
        Console.WriteLine();
    }
}
