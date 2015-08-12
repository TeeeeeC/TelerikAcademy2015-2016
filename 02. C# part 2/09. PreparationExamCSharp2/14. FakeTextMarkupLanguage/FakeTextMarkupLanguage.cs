using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class FakeTextMarkupLanguage
{
    static List<string> lines = new List<string>();

    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            lines.Add(Console.ReadLine());
        }

        FindFormattedText(lines);
    }

    static void FindFormattedText(List<string> lines)
    {
        foreach(string row in lines)
        {
            char symbol = row[0];
            int countTags = 0;

            for (int i = 1; i < row.Length - 1; i++)
            {
                if(symbol == '<')
                {

                }
            }
        }
    }
}
