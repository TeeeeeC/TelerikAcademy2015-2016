using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        /*
         Problem 22. Words count
            Write a program that reads a string from the console and lists all different words in the string along with 
            information how many times each word is found.
         */
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        string[] words = text.Split(new char[] { ',', ' ', ':', ';', '.', '!', '?', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        HashSet<string> letters = new HashSet<string>();

        foreach (var word in words)
        {
            letters.Add(word);
        }

        Dictionary<string, int> countWords = new Dictionary<string, int>();

        foreach (var item in letters)
        {
            countWords[item] = 0;
        }

        foreach (var word in words)
        {
            foreach (var key in countWords.Keys)
            {
                if (word == key)
                {
                    countWords[key] += 1;
                    break;
                }
            }
        }

        foreach (var symbol in countWords)
        {
            Console.WriteLine("{0} -> {1} times", symbol.Key, symbol.Value);
        }
    }
}
