using System;

class CheckIntIsOddOrEven
{
    static void Main()
    {
        /*
         Problem 1. Odd or Even Integers
            Write an expression that checks if given integer is odd or even.
         */
        Console.Write("Insert number: ");
        int number = int.Parse(Console.ReadLine());
        int divide = number % 2;

        bool result = (divide == 0);
        Console.WriteLine("True for even or Fasle for odd: {0}", result);
    }
}
