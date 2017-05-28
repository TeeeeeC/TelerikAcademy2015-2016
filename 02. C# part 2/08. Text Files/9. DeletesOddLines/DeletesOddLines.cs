using System;
using System.Collections.Generic;
using System.IO;

class DeletesOddLines
{
    static void Main()
    {
        /*
         Problem 9. Delete odd lines
            Write a program that deletes from given text file all odd lines.
            The result should be in the same file.
         */
        StreamReader reader = new StreamReader("text.txt");
        List<string> arrStr = new List<string>();
        string[] str = new string[] { "" };

        int oddLines = 1;
        string empty = string.Empty;

        using(reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                if (oddLines %2 == 0)
                {
                    arrStr.Add(line);
                }

                line = reader.ReadLine();
                oddLines++;
            }

        }

        StreamWriter writer = new StreamWriter("text.txt");

        using (writer)
        {
            for (int i = 0; i <= oddLines; i++)
            {
                writer.WriteLine(empty);
            }
        }
        
        StreamWriter writer1 = new StreamWriter("text.txt");

        using (writer1)
        {
            foreach(string item in arrStr)
            {
                writer1.WriteLine(item);
            }
        }
        
    }
}
