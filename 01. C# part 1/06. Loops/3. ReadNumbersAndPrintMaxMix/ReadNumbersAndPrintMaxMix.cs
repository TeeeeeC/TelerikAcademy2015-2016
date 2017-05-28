using System;

class ReadNumbersAndPrintMaxMix
{
    static void Main()
    {
        /*
         Problem 3. Min, Max, Sum and Average of N Numbers
            Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
            The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
            The output is like in the examples below.
         */
        string str = "";
        int number = 0, positive = -1;

        do
        {
            Console.Write(" Insert number: ");
            str = Console.ReadLine();
            int.TryParse(str, out positive);

        } while ((!(int.TryParse(str, out number))) || (positive < 0));

        Console.WriteLine();
        Console.WriteLine(" Insert {0} number \n", number);

        int max = 0; 
        int min = int.MaxValue;
        int numbers = 0;
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            do
            {
                Console.Write(" Insert  number {0}: ", i);
                str = Console.ReadLine();
                int.TryParse(str, out numbers);
                max = Math.Max(max, numbers);
                min = Math.Min(min, numbers);
                sum += numbers;

            } while ((!(int.TryParse(str, out numbers))));
        }

        float avg = (float)sum / number;
        Console.WriteLine();
        Console.WriteLine(" Min number: {0}\n Max number: {1}\n Sum: {2}\n Avg: {3}\n", min, max, sum, avg);
    }
}
