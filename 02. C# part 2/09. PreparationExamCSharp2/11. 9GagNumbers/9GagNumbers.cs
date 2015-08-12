using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] symbols = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
        var numbers = new List<int>();

        string input = Console.ReadLine();
        int oldIndex = 0;
        int index = 0;
        int i = 0;

        while(true)
        {
            oldIndex = index;
            int countEquals = 0;
            string currStr = symbols[i];
            for (int j = 0; j < currStr.Length; j++)
            {
                if (index > input.Length - 1)
                {
                    break;
                }
 
                if(currStr[j] == input[index])
                {
                    countEquals++;
                    index++;

                    if (countEquals == currStr.Length)
                    {
                        numbers.Add(i);
                    }
                }
                else
                {
                    index = oldIndex;
                    break;
                }      
            }

            if (index > input.Length - 1)
            {
                break;
            }

            if(i < symbols.Length - 1)
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }

        long result = 0;
        long power = numbers.Count - 1;

        foreach(var num in numbers)
        {
            result += num * (long)Math.Pow(9, power);
            power--;
        }

        Console.WriteLine(result);
    }
}
///TO DOOOOOOOOOOOOOOOOOOoo