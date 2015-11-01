using System;

class CalculateFactorialTask
{
    static void Main()
    {
        /*
         Problem 6. Calculate N! / K!
            Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            Use only one loop.
         */
        Console.WriteLine(" Calculate Factorial Task (1<k<n)\n");

        Console.Write(" Insert number N: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write(" Insert number K: ");
        int numberK = int.Parse(Console.ReadLine());

        float result = 1;

        for (int i = numberN; i > 1; i--)
        {
            result *= (float) i / numberK;
            
            if (numberK > 1)
            {
                numberK--;
            }
        }
        Console.WriteLine();
        Console.WriteLine(" The result is {0}!\n", (int)result);
    }
}

