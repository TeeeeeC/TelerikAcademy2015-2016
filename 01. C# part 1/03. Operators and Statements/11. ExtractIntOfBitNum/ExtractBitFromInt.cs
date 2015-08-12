using System;

class ExtractBitFromInt
{
    static void Main()
    {
        /*
         Problem 12. Extract Bit from Integer
            Write an expression that extracts from given integer n the value of given bit at index p.
         */
        Console.Write("Insert int: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        Console.Write("Insert position: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int result = n & mask;
        int bit = result >> p;

        Console.WriteLine(bit); 
    }
}
