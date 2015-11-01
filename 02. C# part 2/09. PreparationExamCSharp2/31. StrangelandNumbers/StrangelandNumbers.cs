using System;
using System.Collections.Generic;
using System.Text;

class StrangelandNumbers
{
    static void Main()
    {
        string[] strangeNums = { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
        var digits = new List<int>();

        string input = Console.ReadLine();

        var sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            sb.Append(input[i]);

            for (int j = 0; j < strangeNums.Length; j++)
            {
                if (strangeNums[j] == sb.ToString())
                {
                    digits.Add(j);
                    sb.Clear();
                    break;
                }
            }
        }

        int power = digits.Count - 1;
        long result = 0;
        for (int i = 0; i < digits.Count; i++)
        {
            result += digits[i] * (long)Math.Pow(7, power);
            power--;
        }
        Console.WriteLine(result);
    }
}
