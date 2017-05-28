using System;

class ModifyBitAtGivenPos
{
    static void Main()
    {
        /*
         Problem 14. Modify a Bit at Given Position
            We are given an integer number n, a bit value v (v=0 or 1) and a position p.
            Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position 
         * p from the binary representation of n while preserving all other bits in n.
         */
        Console.Write("Insert n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        Console.Write("Insert p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Insert v: ");
        int v = int.Parse(Console.ReadLine());

        int mask = 0, result = 0;

        if (v == 0)
        {
            mask = ~(1 << p);
            result = n & mask;
        }
        else
        {
            mask = 1 << p;
            result = n | mask;
        }
         
        Console.WriteLine("p = {0}", p);
        Console.WriteLine("v = {0}", v);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.WriteLine(result);
    }
}
