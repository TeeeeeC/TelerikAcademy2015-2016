using System;

class FibonacciMembers
{
    static void Main()
    {
        /*
         Problem 10. Fibonacci Numbers
            Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
            (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
         */
        int n = int.Parse(Console.ReadLine());
        int previosValue = 0;
        int lastValue = 1;

        Console.Write(previosValue + ", " + lastValue + ", ");

        for (int i = 0; i < n - 2; i++)
        {
            int result = lastValue + previosValue;
            Console.Write(result + ", ");
            previosValue = lastValue;
            lastValue = result;
        }

        Console.WriteLine();
    }
}

