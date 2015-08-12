using System;

class PrintGreaterOfTwoNumbers
{
    static void Main()
    {
        /*
        Problem 4. Number Comparer
            Write a program that gets two numbers from the console and prints the greater of them.
            Try to implement this without if statements.
         */
        Console.WriteLine("");
        Console.Write(" First number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write(" Second number: ");
        float secondNumber = float.Parse(Console.ReadLine());

        Console.WriteLine(" Greater number is {0}!", Math.Max(firstNumber, secondNumber));
    }
}

