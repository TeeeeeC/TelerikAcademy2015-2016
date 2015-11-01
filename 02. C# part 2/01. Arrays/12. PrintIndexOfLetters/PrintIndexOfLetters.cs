using System;

class PrintIndexOfLetters
{
    static void Main()
    {
        /*
         Problem 12. Index of letters
            Write a program that creates an array containing all letters from the alphabet (A-Z).
            Read a word from the console and print the index of each of its letters in the array.
         */
        char[] upperLetters = new char[26];
        int i = 0;

        for (char ch = 'A'; ch <= 'Z'; ch++)
        {
            upperLetters[i] = ch;
            i++;
        }

        Console.Write("Please issue the word: ");
        string word = Console.ReadLine();

        for (i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < upperLetters.Length; j++)
            {
                if (word[i] == upperLetters[j])
                {
                    Console.Write("{0}, ", j);
                    break;
                }
            }
        }

        Console.WriteLine();
    }
}
