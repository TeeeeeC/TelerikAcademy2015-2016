using System;
using System.Collections.Generic;
using System.Text;

class MovingLetters
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

        var resultOfExtracting = ExtractLetters(words);
        var result = MoveLetters(resultOfExtracting);

        Console.WriteLine(result);
    }

    static StringBuilder MoveLetters(StringBuilder resultOfExtracting)
    {
        var sb = resultOfExtracting;

        for (int i = 0; i < sb.Length; i++)
        {
            char currSym = sb[i];
            int countMovement = char.ToLower(currSym) - 'a' + 1;

            int startIndex = (countMovement + i) % sb.Length;
            sb.Remove(i, 1);
            sb.Insert(startIndex, currSym);
       
        }
        return sb;
    }

    static StringBuilder ExtractLetters(string[] words)
    {
        var maxLenOfWord = 0;
        foreach (var item in words)
        {
            if(item.Length > maxLenOfWord)
            {
                maxLenOfWord = item.Length;
            }
        }

        StringBuilder sb = new StringBuilder();
        int count = 0;

        while(maxLenOfWord > 0)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > count)
                {
                    sb.Append(words[i][words[i].Length - 1 - count]);
                }
            }
            maxLenOfWord--;
            count++;
        }

        return sb;
    }
}
