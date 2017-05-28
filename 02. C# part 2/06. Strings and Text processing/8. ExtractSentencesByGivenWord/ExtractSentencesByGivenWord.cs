using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractSentencesByGivenWord
{
    private static string text = "We are living in a yellow submarine. We don't have" +
                        " anything else. Inside the submarine is very tight. So we are drinking"
                        + " all day. We will move out of it in 5 days.";

    private static List<string> sentences = new List<string>();

    private static int FindUpperLetter(int currIndex)
    {
        /*
         Problem 8. Extract sentences
            Write a program that extracts from a given text all sentences containing given word.
            Example:
            The word is: in
            The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
            The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
            Consider that the sentences are separated by . and the words – by non-letter symbols.
         */
        int i = currIndex;
        int indexStartSentence;

        while (true)
        {
            char ch = text[i];

            if (Char.IsUpper(ch))
            {
                indexStartSentence = i;
                return indexStartSentence;
            }

            if (i == 0)
            {
                break;
            }

            i--;
        }

        return -1;
    }


    static void Main()
    {
        string word = "[ ](in)[ ]";
        Regex reg = new Regex(word);
        int index = 0;
        
        while (true)
        {
            Match match = reg.Match(text, index);

            if (match.Success)
            {
                int startIndex = FindUpperLetter(match.Index);

                if (startIndex == - 1)
                {
                    index = match.Index + 1;
                    continue;
                }

                int endIndex = text.IndexOf(".", match.Index);
                string sentence = text.Substring(startIndex, endIndex - startIndex + 1);
                sentences.Add(sentence);

                index = match.Index + 1;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("{0}\n", text);

        foreach(string item in sentences)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}
