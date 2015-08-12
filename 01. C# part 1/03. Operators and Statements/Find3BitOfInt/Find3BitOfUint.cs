using System;

class Find3BitOfUint
{
    static void Main()
    {
        /*
         Problem 11. Bitwise: Extract Bit #3
            Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
            The bits are counted from right to left, starting from bit #0.
            The result of the expression should be either 1 or 0.
         */
        Console.Write("Insert Uint: ");
        uint n = uint.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int result = (int)n & mask;
        int bit = result >> p;

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine("The bit 3 of the integer is {0}!",bit);
    }
}