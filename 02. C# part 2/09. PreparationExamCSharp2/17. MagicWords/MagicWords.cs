using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var words = new List<string>();

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            string word = words[i];
            int newIndex = word.Length % (n + 1);

            words.Insert(newIndex, word);
            if(newIndex < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }

        int maxLength = words.Max(x => x.Length);
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < maxLength; i++)
        {
            foreach(var word in words)
            {
                if(i < word.Length)
                {
                    sb.Append(word[i]);
                }
            }
        }

        Console.WriteLine(sb);
    }
}
