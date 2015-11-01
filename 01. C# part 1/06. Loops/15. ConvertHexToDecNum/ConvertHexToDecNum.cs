using System;

class ConvertHexToDecNum
{
    static void Main()
    {
        /*
         Problem 15. Hexadecimal to Decimal Number
            Using loops write a program that converts a hexadecimal integer number to its decimal form.
            The input is entered as string. The output should be a variable of type long.
            Do not use the built-in .NET functionality.
         */
        Console.Write("Hex number: ");
        string numHex = Console.ReadLine();

        long result = 0;
        int counter = 0;

        for (int i = numHex.Length - 1; i >= 0; i--)
        {
            int digit = (int)numHex[i] - 48;

            switch (numHex[i])
            {
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
            }

            result += (long)Math.Pow(16, counter) * digit;
            counter++;
        }

        Console.WriteLine("Decimal num: {0}", result);
    }
}
