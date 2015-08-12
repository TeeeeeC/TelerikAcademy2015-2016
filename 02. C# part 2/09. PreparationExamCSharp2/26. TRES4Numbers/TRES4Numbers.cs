using System;
using System.Collections.Generic;
using System.Text;

class TRES4Numbers
{
    static void Main()
    {
        string[] tres4Numbers = { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

        ulong number = ulong.Parse(Console.ReadLine());

        if(number == 0)
        {
            Console.WriteLine("LON+");
            return;
        }

        string result = string.Empty;
        while(number > 0)
        {
            result = tres4Numbers[number % 9] + result;
            number /= 9;
        }

        Console.WriteLine(result);
    }
}
