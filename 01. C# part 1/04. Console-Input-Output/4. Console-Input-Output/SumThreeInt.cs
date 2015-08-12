using System;

class SumThreeInt
{
    static void Main()
    {
        /*
         Problem 1. Sum of 3 Numbers
            Write a program that reads 3 real numbers from the console and prints their sum.
         */
        Console.Write("Insert first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Insert second number: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.Write("Insert third number: ");
        double number3 = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum is {0}", number1 + number2 + number3);
    }
}

