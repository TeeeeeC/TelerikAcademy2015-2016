using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        /*
         Problem 21. Letters count
            Write a program that reads a string from the console and prints all different letters in the string along with information 
            how many times each letter is found.
         */
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        HashSet<char> letters = new HashSet<char>();
        
        foreach(var symbol in text)
        {
            letters.Add(symbol);
        }

        Dictionary<char, int> countSymbols = new Dictionary<char, int>();

        foreach(var item in letters)
        {
            countSymbols[item] = 0;
        }

        foreach (var symbol in text)
        {
            foreach (var key in countSymbols.Keys)
            {
                if(symbol == key)
                {
                    countSymbols[key] += 1;
                    break;
                }
            }
        }

        foreach (var symbol in countSymbols)
        {
            Console.WriteLine("{0} -> {1} times", symbol.Key, symbol.Value);
        }
    }
}
