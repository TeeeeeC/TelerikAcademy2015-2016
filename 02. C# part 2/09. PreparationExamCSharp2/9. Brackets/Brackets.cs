using System;
using System.Collections.Generic;
using System.Text;

class Brackets
{
    static StringBuilder sb = new StringBuilder();
    static string tabs;
    static int tabCount = 0;
    static bool shouldPrintNewLine = false;
    static bool isFirstSymbol = true;

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        tabs = Console.ReadLine();

        for (int i = 0; i < numberN; i++)
        {
            string line = Console.ReadLine();

            HandleLine(line);
        }

        Console.WriteLine(sb.ToString());
    }

    private static void HandleLine(string line)
    {
        for (int i = 0; i < line.Length; i++)
        {
            if (shouldPrintNewLine && line[i] != '{' && line[i] != '}')
            {
                sb.AppendLine();
                shouldPrintNewLine = false;
                isFirstSymbol = true;
            }

            char currChar = line[i];

            if(currChar == '{')
            {
                if (!isFirstSymbol)
                {
                    sb.AppendLine();
                }
                AppendTabs();
                sb.Append(currChar);
                tabCount++;
                shouldPrintNewLine = true;
            }
            else if(currChar == '}')
            {
                tabCount--;
                sb.AppendLine();
                AppendTabs();
                sb.Append(currChar);
                shouldPrintNewLine = true;
            }
            else
            {
                if (isFirstSymbol)
                {
                    AppendTabs();
                }

                if (!(isFirstSymbol && char.IsWhiteSpace(currChar)))
                {
                    if (!(i < line.Length - 1 && char.IsWhiteSpace(line[i]) && char.IsWhiteSpace(line[i + 1])))
                    {
                        sb.Append(currChar);
                    }
                }
                isFirstSymbol = false;
            }
        }
    }

    private static void AppendTabs()
    {
        for (int i = 0; i < tabCount; i++)
        {
            sb.Append(tabs);
        }
    }
}
