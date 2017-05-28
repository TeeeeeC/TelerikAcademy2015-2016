using System;

class ExchangeBitsOfUint
{
    static void Main()
    {
        /*
         Problem 15.* Bits Exchange
            Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer
         */
        Console.Write("Enter number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine();

        string binaryNum = Convert.ToString(n, 2).PadLeft(32, '0');
        string leftBits = binaryNum.Substring(5, 3);
        string rightBits = binaryNum.Substring(binaryNum.Length - 6, 3);
        string result = binaryNum.Substring(0, 5) + rightBits + binaryNum.Substring(8, 18) + leftBits + binaryNum.Substring(29, 3);

        Console.WriteLine("Binary result: {0}", result);
        Console.WriteLine("Uint result: {0}", Convert.ToUInt32(result, 2));
    }   
}
