using System;


class RepresentShortToBin
{
    static void Main()
    {
        /*
         Problem 8. Binary short
            Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
         */
        Console.Write("Insert decimal short type number: ");
        short num = short.Parse(Console.ReadLine());

        int[] binary = new int[16];
        int remainder = -1;
        int index = 15;

        if (num < 0)
        {
            binary[0] = 1;
            num *= -1;
            num = (short)(32768 - num);
        }

        while (num != 0)
        {
            remainder = num % 2;
            binary[index] = remainder;
            index--;
            num /= 2;
        } 

        foreach (int elem in binary)
        {
            Console.Write("{0}", elem);
        }

        Console.WriteLine();
    }
}