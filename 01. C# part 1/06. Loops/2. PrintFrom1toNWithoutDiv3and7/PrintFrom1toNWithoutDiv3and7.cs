using System;

class PrintFrom1toNWithoutDiv3and7
{
    static void Main()
    {
        /*
         Problem 2. Numbers Not Divisible by 3 and 7
            Write a program that enters from the console a positive integer n and prints 
            all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
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
            if (i % 3 > 0 && i % 7 > 0)
            {
                Console.Write(" {0} ", i);
            }
        }
        Console.WriteLine();
    }
}
