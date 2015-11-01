using System;
using System.Text;

class ChangeTextToUppercase
{
    static void Main()
    {
        /*
         Problem 5. Parse tags
            You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
            The tags cannot be nested.
            Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

            The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
         */
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string updateText = "";    

        int start = 0, end = 0;

        while (true)
        {
            start = text.IndexOf("<upcase>", start);
            end = text.IndexOf("</upcase>", end);

            if (start == -1 || end == -1)
            {
                break;
            }

            string lowerCase = text.Substring(start + 8, end - start - 8);
            string upperCase = lowerCase.ToUpper();
            updateText = text.Replace(lowerCase, upperCase);
            text = updateText;

            if (start != -1 && end != -1)
            {
                start++;
                end++;
            }
        }

        string removeText = updateText.Replace("<upcase>", "");
        string finalUpdateText = removeText.Replace("</upcase>", "");

        Console.WriteLine("{0}\n", text);
        Console.WriteLine(finalUpdateText);
    }
}
