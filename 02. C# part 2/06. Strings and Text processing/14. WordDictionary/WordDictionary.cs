using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        /*
         Problem 14. Word dictionary
            A dictionary is stored as a sequence of text lines containing words and their explanations.
            Write a program that enters a word and translates it by using the dictionary.
         */
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary[".Net"] = "platform for application from Microsoft";
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary["namespace"] = "hierarchical organization of classes";

        Console.Write("Enter a word from dictionary (.NET, CLR or namespace): ");
        string input = Console.ReadLine();

        bool noFoundWord = true;

        foreach(var explanation in dictionary)
        {
            if(explanation.Key == input)
            {
                Console.WriteLine("{0}: {1}", explanation.Key, explanation.Value);
                noFoundWord = false;
                break;
            }
        }

        if(noFoundWord)
        {
            Console.WriteLine("There is no word '{0}' in the dictionary!", input);
        }
    }
}
