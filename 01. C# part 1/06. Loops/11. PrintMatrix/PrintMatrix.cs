using System;

class PrintMatrix
{
    static void Main()
    {
        /*
         Problem 9. Matrix of Numbers
            Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix 
            like in the examples below. Use two nested loops.
         */
        string strN = "";
        int numberN = 0;

        Console.WriteLine(" Maxtrix Task\n");

        do
        {
            Console.Write(" Insert number N: ");
            strN = Console.ReadLine();
            int.TryParse(strN, out numberN);

        } while ((!(int.TryParse(strN, out numberN))) || ((numberN < 1) || (numberN > 19)));

        for (int row = 1; row <= numberN; row++)
        {
            for (int column = row; column <= numberN + row - 1; column++)
            {
                Console.Write(" {0} ", column);
            }
            Console.WriteLine();
        }
    }
}

