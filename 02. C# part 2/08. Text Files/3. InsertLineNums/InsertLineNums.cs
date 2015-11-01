using System;
using System.IO;

class InsertLineNums
{
    static void Main()
    {
        /*
         Problem 3. Line numbers
            Write a program that reads a text file and inserts line numbers in front of each of its lines.
            The result should be written to another text file.
         */
        StreamReader reader = new StreamReader("Read.txt");
        StreamWriter writer = new StreamWriter("Write.txt");

        int countLines = 0;
        string line = reader.ReadLine();

        using (reader)
        {
            while (line != null)
            {
                countLines++;
                writer.WriteLine("Line number {0}: {1}", countLines, line);
                line = reader.ReadLine();
            }
        }

        writer.Close();
    }
}
