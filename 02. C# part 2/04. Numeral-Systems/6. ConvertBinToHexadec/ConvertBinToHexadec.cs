using System;
using System.Collections.Generic;

class ConvertBinToHexadec
{
    static void Main()
    {
        /*
         Problem 6. binary to hexadecimal
            Write a program to convert binary numbers to hexadecimal numbers (directly).
         */
        string hexaNum = string.Empty;

        do
        {
            Console.Write("Insert bin number: ");
            hexaNum = Console.ReadLine();

        }while(hexaNum.Length % 4 != 0);

        char[] arrHexa = { '1', '2', '3', '4', '5', '6', '7', 
                           '8', '9','A', 'B', 'C', 'D', 'E', 'F'};

        string[] arrBin = { "0001", "0010", "0011", "0100", "0101", "0110", "0111", 
                           "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"};

        for (int i = 0; i < hexaNum.Length; i += 4)
        {
            string bin = hexaNum.Substring(i, 4);
            int index = 0;

            for (int j = 0; j < arrBin.Length; j++)
            {
                if (bin == arrBin[j])
                {
                    index = j;
                }
            }
            Console.Write(arrHexa[index]);
        }

        Console.WriteLine();
    }
}
