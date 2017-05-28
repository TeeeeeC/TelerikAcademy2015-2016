using System;
using System.Numerics;

class FindFactorInRange
{
    static void Main()
    {
        /*
         Problem 10. N Factorial
            Write a program to calculate n! for each n in the range [1..100].
            Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
         */
        int number = 0;

        Console.Write("Insert number to calculate n!: ");
        string text = Console.ReadLine();
        int.TryParse(text, out number);

        if (number < 1)
        {
            number = 1;
        }
        else if (number > 100)
        {
            number = 100;
        }

        FindFactoriel(number);
    }

    static  void FindFactoriel(int number)
    {
        BigInteger factoriel = new BigInteger();

        factoriel = 1;

        for (int i = 1; i <= number; i++)
        {
            factoriel *= i;
        }

        Console.WriteLine("{0}", factoriel);
    }
}