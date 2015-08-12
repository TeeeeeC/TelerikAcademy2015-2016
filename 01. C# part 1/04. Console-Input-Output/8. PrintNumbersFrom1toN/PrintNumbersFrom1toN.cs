using System;

class PrintNumbersFrom1toN
{
    static void Main()
    {
        /*
         Problem 8. Numbers from 1 to n
            Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
         */
        Console.WriteLine("");
        int n = 0;

        while (n < 1)
        {
            Console.Write(" Number n: ");
            string str = Console.ReadLine();

            while (!(int.TryParse(str, out n)))
            {
                Console.Write(" Number n: ");
                str = Console.ReadLine();
            }
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

