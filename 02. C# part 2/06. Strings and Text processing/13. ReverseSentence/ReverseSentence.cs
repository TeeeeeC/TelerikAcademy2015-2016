using System;
using System.Collections.Generic;

class ReverseSentence
{
    static void Main()
    {
        /*
         Problem 13. Reverse sentence
            Write a program that reverses the words in given sentence.
            C# is not C++, not PHP: and not; Delphi!
         */

        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();

        RevSentence(input);
    }

    static void RevSentence(string input)
    {
        string[] words = input.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> index = new List<int>();
        List<char> sign = new List<char>();
        int currIndex = -1;

        for (int i = 0; i < words.Length; i++)
        {
            currIndex = input.IndexOf(words[i], currIndex + 1);

            if(currIndex > 2)
            {
                if (input[currIndex - 2] == ',' || input[currIndex - 2] == ':' || input[currIndex - 2] == ';')
                {
                    switch(input[currIndex - 2])
                    {
                        case ',': 
                            index.Add(i);
                            sign.Add(',');
                            break;
                        case ':': 
                            index.Add(i);
                            sign.Add(':');
                            break;
                        case ';': 
                            index.Add(i);
                            sign.Add(';');
                            break;
                    }
                }
            }
        }

        int counter = 0;

        Console.Write("Reversed Sentence: ");
        for (int i = words.Length - 1; i >= 0; i--)
        {
            for (int j = index.Count - 1; j >= 0; j--)
            {
                if (counter == index[j])
                {
                    Console.Write("\b{0} ", sign[j]);
                }
            }
            Console.Write("{0} ", words[i]);
            counter++;
        }

        Console.Write("\b{0}", input[input.Length - 1]);
        Console.WriteLine();
    }
}
