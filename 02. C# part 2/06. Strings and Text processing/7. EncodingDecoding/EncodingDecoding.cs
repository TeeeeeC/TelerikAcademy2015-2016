using System;
using System.Collections.Generic;

class EncodingDecoding
{
    static void Main()
    {
        /*
         Problem 7. Encode/decode
            Write a program that encodes and decodes a string using given encryption key (cipher).
            The key consists of a sequence of characters.
            The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
            the second – with the second, etc. When the last key character is reached, the next is the first.
         */
        Console.Write("Word for encoding: ");
        string word = Console.ReadLine();
        Console.Write("Chiper: ");
        string chiper = Console.ReadLine();

        int indexOfChiper = -1;
        List<int> result = new List<int>();

        for (int i = 0; i < word.Length; i++)
        {
            indexOfChiper++;

            if (indexOfChiper == chiper.Length)
            {
                indexOfChiper = 0;
            }

            result.Add(word[i] ^ chiper[indexOfChiper]);
        }

        foreach(int item in result)
        {
            Console.Write("\\u{0:x4}", item);
        }

        Console.WriteLine();
    }
}
