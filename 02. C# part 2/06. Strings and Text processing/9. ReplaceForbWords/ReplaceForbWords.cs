using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class ReplaceForbWords
{
    static void Main()
    {
        /*
         Problem 9. Forbidden words
            We are given a string containing a list of forbidden words and a text containing some of these words.
            Write a program that replaces the forbidden words with asterisks.
            Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
            Forbidden words: PHP, CLR, Microsoft
            The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
         */
        string text = "Microsoft annouced its next generation PHP compiler today. Its is based"
            + " on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] words = new string[] { "PHP", "CLR", "Microsoft" };
        string newText = string.Empty;
        string oldText = text;

        for (int i = 0; i < words.Length; i++)
        {
            string pattern = @"(?=\b|\s])(" + words[i] + @")(?=\b|.])";
            Regex reg = new Regex(pattern);

            newText = reg.Replace(text, new string('*', words[i].Length));
            text = newText;
        }

        Console.WriteLine("{0}\n", oldText);
        Console.WriteLine(text);
    }
}