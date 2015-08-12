using System;
using System.Collections.Generic;

class ConvertDecToBinNum
{
    static void Main()
    {
        /*
         Problem 14. Decimal to Binary Number
            Using loops write a program that converts an integer number to its binary representation.
            The input is entered as long. The output should be a variable of type string.
            Do not use the built-in .NET functionality.
         */
        Console.Write("Long number: ");
        long num = long.Parse(Console.ReadLine());

        List<long> binary = new List<long>();

        while (num != 0)
        {
            long digit = num % 2;
            binary.Add(digit);
            num /= 2;
        }

        for (int i = binary.Count - 1; i >= 0; i--)
        {
            Console.Write("{0}", binary[i]);
        }

        Console.WriteLine();
    }
}