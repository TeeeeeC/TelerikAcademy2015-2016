using System;

class PrintNumbersSum
{
    static void Main()
    {
        /*
         Problem 7. Sum of 5 Numbers
            Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
         */
        string sequence = Console.ReadLine();

        string[] arr = sequence.Split(' ');
        double sum = 0;

        foreach(string item in arr)
        {
            sum += Convert.ToDouble(item);
        }

        Console.WriteLine(sum);
    }
}

