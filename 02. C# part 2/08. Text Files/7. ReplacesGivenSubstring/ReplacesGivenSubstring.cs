using System;
using System.Text;
using System.IO;

class ReplacesGivenSubstring
{
    static void Main()
    {
        /*
         Problem 7. Replace sub-string
            Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
            Ensure it will work with large files (e.g. 100 MB).
         */
        StreamReader reader = new StreamReader("Read.txt");
        StreamWriter writer = new StreamWriter("Write.txt");

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    StringBuilder sb = new StringBuilder(line);
                    sb.Replace("start", "finish");

                    writer.WriteLine(sb);
                    line = reader.ReadLine();
                }
            }
        }
    }
}