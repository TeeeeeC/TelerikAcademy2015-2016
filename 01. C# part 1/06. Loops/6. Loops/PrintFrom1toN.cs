using System;

class PrintFrom1toN
{
    static void Main()
    {
        /*
         Problem 1. Numbers from 1 to N
            Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
            on a single line, separated by a space.
         */
        string str = "";
        int number = 0, positive = -1;

        do
        {
            Console.Write(" Insert number: ");
            str = Console.ReadLine();
            int.TryParse(str, out positive);

        } while ((!(int.TryParse(str, out number))) || (positive < 0));

        for (int i = 1; i <= number; i++)
        {
            Console.Write(" {0} ", i);
        }
        Console.WriteLine();
    }
}

