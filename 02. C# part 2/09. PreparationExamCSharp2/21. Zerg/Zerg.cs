using System;
using System.Collections.Generic;
using System.Text;

class Zerg
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] encryptedNum = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr",
                                "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
        var numbers = new List<int>();

        for (int i = 0; i < line.Length; i += 4)
        {
            string get4Symbol = line.Substring(i, 4);

            for (int j = 0; j < encryptedNum.Length; j++)
            {
                if (get4Symbol == encryptedNum[j])
                {
                    numbers.Add(j);
                    break;
                }
            }
        }

        int power = numbers.Count - 1;
        long result = 0;

        foreach (int num in numbers)
        {
            result += num * (long)Math.Pow(15, power);
            power--;
        }

        Console.WriteLine(result);
    }
}
