using System;

class ConvertBinToDecNum
{
    static void Main()
    {
        /*
         Problem 13. Binary to Decimal Number
            Using loops write a program that converts a binary integer number to its decimal form.
            The input is entered as string. The output should be a variable of type long.
            Do not use the built-in .NET functionality.
         */
        Console.Write("Binary num: ");
        string inputNum = Console.ReadLine();

        int result = 0;
        int counter = 0;

        for (int i = inputNum.Length - 1; i >= 0; i--)
        {
            int digit = (int)inputNum[i] - 48;

            result += (int)Math.Pow(2, counter) * digit;
            counter++;
        }

        Console.WriteLine("Decimal num: {0}", result);
    }
}
