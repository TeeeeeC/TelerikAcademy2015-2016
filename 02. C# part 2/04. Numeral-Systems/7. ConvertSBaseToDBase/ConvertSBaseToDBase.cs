using System;
using System.Collections.Generic;

class ConvertSBaseToDBase
{
    static void Main()
    {
        /*
         Problem 7. One system to any other
            Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
         */
        Console.Write("Insert base of number s = ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Insert number = ");
        string num = Console.ReadLine();

        Console.Write("Convert number to base d = ");
        int d = int.Parse(Console.ReadLine());

        int sum = 0;
        int power = num.Length;
        int counter = 1;

        for (int i = 0; i < num.Length; i++)
        {
            int digit = num[i] - 48;

            sum += digit * (int)(Math.Pow(s, power - counter));
            counter++;
        }

        List<int> binary = new List<int>();
        int remainder = 0;

        while (sum != 0)
        {
            remainder = sum % d;
            binary.Add(remainder);
            sum /= d;
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
