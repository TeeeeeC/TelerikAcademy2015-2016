using System;
using System.Collections.Generic;

class ConvertDecToHexNum
{
    static void Main()
    {
        /*
         Problem 16. Decimal to Hexadecimal Number
            Using loops write a program that converts an integer number to its hexadecimal representation.
            The input is entered as long. The output should be a variable of type string.
            Do not use the built-in .NET functionality.
         */
        Console.Write("Long number: ");
        long num = long.Parse(Console.ReadLine());

        List<string> binary = new List<string>();
        string ch =  string.Empty;

        while (num != 0)
        {
            long digit = num % 16;

            switch(digit)
            {
                case 10: ch = "A"; break;
                case 11: ch = "B"; break;
                case 12: ch = "C"; break;
                case 13: ch = "D"; break;
                case 14: ch = "E"; break;
                case 15: ch = "F"; break;
                default: ch = Convert.ToString(digit, 16); break;
            }

            binary.Add(ch);
            num /= 16;
        }

        for (int i = binary.Count - 1; i >= 0; i--)
        {
            Console.Write("{0}", binary[i]);
        }

        Console.WriteLine();
    }
}
