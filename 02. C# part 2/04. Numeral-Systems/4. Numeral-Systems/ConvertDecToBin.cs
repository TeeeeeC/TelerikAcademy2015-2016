using System;
using System.Collections.Generic;
class ConvertDecToBin
{
    static void Main()
    {
        /*
         Problem 1. Decimal to binary
            Write a program to convert decimal numbers to their binary representation.
         */
        Console.Write("Insert decimal number: ");
        int num = int.Parse(Console.ReadLine());

        int[] binary = new int[32];
        int remainder = -1;
        int index = 31;

        if (num < 0)
        {
            binary[0] = 1;
            num = int.MinValue + num;
        }

        while (num != 0)
        {
            remainder = num % 2;
            binary[index] = remainder;
            num /= 2;
            index--;
        }

        foreach (int elem in binary)
        {
            Console.Write("{0}", elem);
        }

        Console.WriteLine();
    }
}
