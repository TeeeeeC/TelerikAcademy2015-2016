using System;

class SeriesOfLetters
{
    static void Main()
    {
        /*
         Problem 23. Series of letters
            Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
            input: aaaaabbbbbcdddeeeedssaa
         */
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        char symbol = text[0];

        Console.Write("result: {0}", symbol);

        for (int i = 1; i < text.Length - 1; i++)
        {
            if(symbol != text[i])
            {
                Console.Write(text[i]);
            }

            symbol = text[i];
        }
        Console.WriteLine();
    }
}
