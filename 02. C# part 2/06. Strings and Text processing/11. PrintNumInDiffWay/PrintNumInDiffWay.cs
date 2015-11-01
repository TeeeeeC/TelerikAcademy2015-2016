using System;

class PrintNumInDiffWay
{
    static void Main()
    {
        /*
         Problem 11. Format number
            Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
            Format the output aligned right in 15 symbols.
         */
        Console.Write("Insert number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("{0:d15}", num);
        Console.WriteLine("{0:x15}", num);
        Console.WriteLine("{0:p7}", num);
        Console.WriteLine("{0:e8}", num);
    }
}
