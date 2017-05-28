using System;

class CheckBitInPos
{
    static void Main(string[] arg)
    {
        /*
         Problem 13. Check a Bit at Given Position
            Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
         */
        Console.Write("Insert int: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        Console.Write("Insert position: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int result = n & mask;
        int bit = result >> p;

        Boolean bit1 = (bit == 1);

        Console.WriteLine("The bit in position {2} is {0} ---> {1}!", bit, bit1, p);
    }
}