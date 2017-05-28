using System;

class OrderWords
{
    static void Main()
    {
        /*
         Problem 24. Order words
            Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
         */
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        foreach(var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
