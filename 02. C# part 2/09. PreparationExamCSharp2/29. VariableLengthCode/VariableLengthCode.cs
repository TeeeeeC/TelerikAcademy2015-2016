using System;
using System.Collections.Generic;
using System.Text;

class VariableLengthCode
{
    static StringBuilder sb = new StringBuilder();
    static Dictionary<char, int> dict = new Dictionary<char, int>();

    static void Main()
    {
        Input(sb);

        var decodedText = FindDecodedText(sb);
        Console.WriteLine(decodedText);
    }

    private static StringBuilder FindDecodedText(StringBuilder sb)
    {
        StringBuilder result = new StringBuilder();

        int countSeqOfOnes = 1;
        char currDigit = sb[0];
        for (int i = 1; i < sb.Length; i++)
        {
            if (currDigit == sb[i] && currDigit == '1' && sb[i] == '1')
            {
                countSeqOfOnes++;
            }
            else if (currDigit == sb[i] && currDigit == '0' && sb[i] == '0')
            {
                continue;
            }
            else if (i == 1 && currDigit == '1' && sb[i] == '0' && countSeqOfOnes == 1)
            {
                foreach (var item in dict)
                {
                    if (countSeqOfOnes == item.Value)
                    {
                        result.Append(item.Key);
                        break;
                    }
                }
            }
            else
            {
                if (i > 1 && sb[i - 2] == '0' && currDigit == '1' && sb[i] == '0' && countSeqOfOnes == 1)
                {
                    foreach (var item in dict)
                    {
                        if(countSeqOfOnes == item.Value)
                        {
                            result.Append(item.Key);
                            break;
                        }
                    }
                }
                else if (countSeqOfOnes > 1)
                {
                    foreach (var item in dict)
                    {
                        if (countSeqOfOnes == item.Value)
                        {
                            result.Append(item.Key);
                            break;
                        }
                    }
                }
                countSeqOfOnes = 1;
            }
            currDigit = sb[i];    
        }

        return result;
    }

    private static void Input(StringBuilder sb)
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var elem in numbers)
        {
            string num = Convert.ToString(int.Parse(elem), 2).PadLeft(8, '0');
            foreach (var digit in num)
            {
                sb.Append(digit);
            }
        }

        int numberOfLinesOfCodeTable = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLinesOfCodeTable; i++)
        {
            string line = Console.ReadLine();
            dict[line[0]] = int.Parse(line.Substring(1, line.Length - 1));
        }
    }
}
