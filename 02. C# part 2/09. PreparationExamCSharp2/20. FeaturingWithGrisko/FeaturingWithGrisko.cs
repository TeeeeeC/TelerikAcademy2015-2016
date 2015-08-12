using System;
using System.Collections.Generic;

class FeaturingWithGrisko
{
    static void Main()
    {
        string word = Console.ReadLine();
        if(word.Length == 1)
        {
            Console.WriteLine("1");
            return;
        }
        var result = FindPermutations(word);

        int countWords = 0;
        foreach (var item in result)
        {
            if (IsMatch(item))
            {
                countWords++;
            }
        }
        Console.WriteLine(countWords);
    }

    private static bool IsMatch(string item)
    {
        for(int i = 1; i < item.Length; i++)
        {
            if(item[i] == item[i - 1])
            {
                return false;
            }
        }

        return true;
    }



    public static HashSet<string> FindPermutations(string word)
    {
        if (word.Length == 2)
        {
            char[] _c = word.ToCharArray();
            string s = new string(new char[] { _c[1], _c[0] });
            return new HashSet<string> { word, s };
        }

        var _result = new HashSet<string>();

        var _subsetPermutations = FindPermutations(word.Substring(1));
        char _firstChar = word[0];

        foreach (string s in _subsetPermutations)
        {
            string _temp = _firstChar.ToString() + s;
            _result.Add(_temp);
            char[] _chars = _temp.ToCharArray();

            for (int i = 0; i < _temp.Length - 1; i++)
            {
                char t = _chars[i];
                _chars[i] = _chars[i + 1];
                _chars[i + 1] = t;
                string s2 = new string(_chars);
                _result.Add(s2);
            }
        }

        return _result;
    }
}
