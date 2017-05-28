using System;
using System.Numerics;

class FactorialTrailingZerosCount
{
    static void Main()
    {
        /*
         Problem 18.* Trailing Zeroes in N!
            Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
            Your program should work well for very big numbers, e.g. n=100000.
         */
        Console.WriteLine(" Factorial Trailing Zeros Count\n");
        string strN = "";
        int numberN = 0;

        do
        {
            Console.Write(" Insert number N: ");
            strN = Console.ReadLine();
            int.TryParse(strN, out numberN);

        } while ((!(int.TryParse(strN, out numberN))) || (numberN < 0));

        int divider = 5;
        int trailingZeroes = 0;


        while (divider <= numberN)
        {
            trailingZeroes += numberN / divider;
            divider *= 5;
        }
        Console.WriteLine(" Trailing zeroes: {0}", trailingZeroes);
        Console.WriteLine();
    }
}
