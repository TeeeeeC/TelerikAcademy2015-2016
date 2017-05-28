using System;
using System.Collections.Generic;

class ConvertDecToHexadec
{
    static void Main()
    {
        /*
         Problem 3. Decimal to hexadecimal
            Write a program to convert decimal numbers to their hexadecimal representation.
         */
        Console.Write("Insert decimal number: ");
        int num = int.Parse(Console.ReadLine());

        List<int> binary = new List<int>();
        int remainder = 0;

        while (num != 0)
        {
            remainder = num % 16;
            binary.Add(remainder);
            num /= 16;
        }

        int[] arr = { 10, 11, 12, 13, 14, 15 };

        for (int i = binary.Count - 1; i >= 0; i--)
        {
            switch (binary[i])
            {
                case 10: Console.Write("A"); continue;
                case 11: Console.Write("B"); continue;
                case 12: Console.Write("C"); continue;
                case 13: Console.Write("D"); continue;
                case 14: Console.Write("E"); continue;
                case 15: Console.Write("F"); continue;
            }
            Console.Write("{0}", binary[i]);
        }

        Console.WriteLine();
    }
}
