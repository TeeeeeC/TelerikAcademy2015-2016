using System;
using System.Collections.Generic;
class ConverBintoDecimal
{
    static void Main()
    {
        /*
         Problem 2. Binary to decimal
            Write a program to convert binary numbers to their decimal representation.
         */
        Console.Write("Insert binary number: ");
        string binNum = Console.ReadLine();

        int sum = 0;
        int power = binNum.Length;
        int counter = 1;

        for (int i = 0; i < binNum.Length; i++)
        {
            int digit = binNum[i] - 48;

            sum += digit * (int)(Math.Pow(2, power - counter));
            counter++;
        }

        Console.WriteLine(sum);
    }
}
