using System;

class CalculateSum
{
    static void Main()
    {
        /*
         Problem 9. Sum of n Numbers
            Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
            Note: You may need to use a for-loop.
         */
        Console.Write("Number: ");
        int numbers = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i < numbers; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine(sum);
    }
}

