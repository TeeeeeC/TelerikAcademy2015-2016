using System;

class ReadStrMax20Char
{
    static void Main()
    {
        /*
         Problem 6. String length
            Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
            the rest of the characters should be filled with *.
            Print the result string into the console.
         */
        string lineOf20Symbols = "";

        do
        {
            Console.Write("Enter string max 20 symbols: ");
            lineOf20Symbols = Console.ReadLine();

        } while (lineOf20Symbols.Length > 20);

        Console.WriteLine(lineOf20Symbols + new string('*', 20 - lineOf20Symbols.Length));
    }   
}
