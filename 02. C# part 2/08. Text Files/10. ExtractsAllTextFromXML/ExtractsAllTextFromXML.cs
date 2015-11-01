using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class ExtractsAllTextFromXML
{
    static void Main()
    {
        /*
         Problem 10. Extract text from XML
            Write a program that extracts from given XML file all the text without the tags.
         */
        List<string> arrStr = new List<string>();
        List<char> letters = new List<char>();
        StreamReader reader = new StreamReader("file.xml");
                          
        using (reader)
        {
            char ch = (char)reader.Read();

            do
            {
                if (ch == '>')
                {
                    ch = (char)reader.Read();

                    if (ch != '<' && (!reader.EndOfStream))
                    {
                        while (ch != '<')
                        {
                            if (ch != '\r' && ch != '\n')
                            {
                                letters.Add(ch);
                            }
                            ch = (char)reader.Read();
                        }
                        
                        string text = string.Join("", letters);

                        if (text != string.Empty)
                        {
                            letters.RemoveRange(0, letters.Count);
                            arrStr.Add(text); 
                        }
                    }
                }
                else
                {
                    ch = (char)reader.Read();
                }
            } while (!reader.EndOfStream);
        }

        foreach(string item in arrStr)
        {
            Console.WriteLine(item);
        }
    }
}
