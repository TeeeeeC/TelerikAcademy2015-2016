using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

class DurankulakNumbers
{
    static void Main(string[] args)
    {
        var numbers = new List<string>();

        for (char ch = 'A'; ch <= 'Z'; ch++)
        {
            numbers.Add(ch.ToString());
        }

        for (char i = 'a'; i <= 'f'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                numbers.Add(i.ToString() + j);

                if (i == 'f' && j == 'L')
                {
                    break;
                }
            }
        }

        string input = Console.ReadLine();
        int power = 0;

        foreach(var upperLetter in input)
        {
            if(char.IsUpper(upperLetter))
            {
                power++;
            }
        }

        BigInteger result = new BigInteger();
        result = 0;
        

        if (input.Length < 3)
        {
            int index = 0;

            if (input.Length == 1)
            {
                index = numbers.FindIndex(x => x == input);
                Console.WriteLine(index);
            }
            else if (!char.IsUpper(input[0]) && input.Length == 2)
            {
                index = numbers.FindIndex(x => x == input);
                Console.WriteLine(index);
            }
            else
            {
                index = numbers.FindIndex(x => x == input[0].ToString());
                result = 168 * index;
                index = numbers.FindIndex(x => x == input[1].ToString());
                result += index;
                Console.WriteLine(result);
            }
        }
        else
        {
            int i = 0;

            while(true)
            {
                if (i == input.Length)
                {
                    Console.WriteLine(result);
                    break;
                }

                if(input[i] >= 'A' && input[i] <= 'Z')
                {
                    int index = numbers.FindIndex(x => x == input[i].ToString());
                    result += index * (BigInteger) Math.Pow(168, power - 1);
                    i++;
                    power--;
                }
                else
                {
                    string symbols = (input[i].ToString() + input[i + 1]);
                    int index = numbers.FindIndex(x => x == symbols);

                    result += index * (BigInteger)Math.Pow(168, power - 1);
                    i += 2;
                    power--;
                }
            }
        }
    }
}
