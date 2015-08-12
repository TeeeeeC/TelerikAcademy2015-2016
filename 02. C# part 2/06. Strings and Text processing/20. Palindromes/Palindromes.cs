using System;
using System.Collections.Generic;
using System.Text;

class Palindromes
{
    static void Main()
    {
        /*
         Problem 20. Palindromes
            Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
         */

        string text = "Write aba program that extracts from aaa given text all palindromes(level), e.g. ABBA, lamal, exe";
        string[] words = text.Split(new char[]{',', ' ', ':', ';', '.', '!', '?', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(text);
        Console.WriteLine();

        foreach(var word in words)
        {
            if(IsWordPalindrom(word))
            {
                Console.WriteLine(word);
            }
        }
    }

    static bool IsWordPalindrom(string word)
    {
        int right = word.Length - 1;

        for (int left = 0; left < word.Length / 2; left++, right--)
        {
            if(word[left] == word[right])
            {
                if(left == word.Length / 2 - 1)
                {
                    return true;
                }
            }
            else
            {
                break;
            }
        }
        return false;
    }
}
