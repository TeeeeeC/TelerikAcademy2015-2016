using System;
using System.Collections.Generic;

class KaspichanNumbers
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());

        List<string> letters = new List<string>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                letters.Add(i.ToString() + j);
            }
        }

        if (num == 0)
        {
            Console.WriteLine("A");
        }

        string result = string.Empty;

        while(num != 0)
        {
            result = letters[(int)(num % 256)] + result;
            num /= 256;
        }

        Console.WriteLine(result);
    }
}
