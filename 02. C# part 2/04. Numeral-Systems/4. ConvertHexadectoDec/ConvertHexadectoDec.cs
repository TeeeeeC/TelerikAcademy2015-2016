using System;
using System.Collections.Generic;

class ConvertHexadectoDec
{
    static void Main()
    {
        /*
         Problem 4. Hexadecimal to decimal
            Write a program to convert hexadecimal numbers to their decimal representation.
         */
        Console.Write("Insert hexadecimal number: ");
        string binNum = Console.ReadLine();

        int sum = 0;
        int power = binNum.Length;
        int counter = 1;

        for (int i = 0; i < binNum.Length; i++)
        {
            int digit = binNum[i] - 48;

            if (binNum[i] == 'A' || binNum[i] == 'B' || binNum[i] == 'C' || binNum[i] == 'D'
                || binNum[i] == 'E' || binNum[i] == 'F')
            {
                digit -= 7;
            }

            sum += digit * (int)(Math.Pow(16, power - counter));
            counter++;
        }

        Console.WriteLine(sum);
    }
}