using System;
using System.IO;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        /*
         Problem 25. Extract text from HTML
            Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
         */
        StreamReader reader = new StreamReader("InputHTML.txt");
        string htmlText = string.Empty;

        using(reader)
        {
            htmlText = reader.ReadToEnd();
        }
        Console.WriteLine("Input HTML text: {0}", htmlText);

        int startTitleIndex = htmlText.IndexOf("<title>", 0);
        int endTitleIndex = htmlText.IndexOf("</title>", 0);

        string title = htmlText.Substring(startTitleIndex + 7, endTitleIndex - startTitleIndex - 7);

        Console.WriteLine("\nTitle: {0}", title);

        StringBuilder text = new StringBuilder();
        char symbol = htmlText[0];
        bool titleExist = false;

        if(title.Length > 0)
        {
            titleExist = true;
        }

        for (int i = 1; i < htmlText.Length - 1; i++)
        {
            if (symbol == '>' && htmlText[i] != '<')
            {
                while (htmlText[i] != '<' && !titleExist)
                {
                    text.Append(htmlText[i]);
                    i++;
                }
                text.Append(' ');
                titleExist = false;
            }

            symbol = htmlText[i];
        }

        Console.WriteLine("Text: {0}", text);
    }
}
