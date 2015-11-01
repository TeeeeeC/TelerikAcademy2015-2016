using System;


class ConvertHexaToBin
{
    static void Main()
    {
        /*
         Problem 5. Hexadecimal to binary
            Write a program to convert hexadecimal numbers to binary numbers (directly).
         */
        Console.Write("Insert hexadecimal number: ");
        string hexaNum = Console.ReadLine();

        char[] arrHexa = { '1', '2', '3', '4', '5', '6', '7', 
                           '8', '9','A', 'B', 'C', 'D', 'E', 'F'};

        string[] arrBin = { "0001", "0010", "0011", "0100", "0101", "0110", "0111", 
                           "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"};

        for (int i = 0; i < hexaNum.Length; i++)
        {
            char ch = hexaNum[i];
            int index = 0;

            for (int j = 0; j < arrHexa.Length; j++)
            {
                if(ch == arrHexa[j])
                {
                    index = j;
                }
            }
            Console.Write(arrBin[index]);
        }

        Console.WriteLine();
    }
}
