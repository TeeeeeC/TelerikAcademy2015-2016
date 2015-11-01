using System;
using System.IO;
using System.Collections.Generic;

class SortListOfStrings
{
    static void Main()
    {
        /*
         Problem 6. Save sorted names
            Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
         */
        StreamReader reader = new StreamReader("Read.txt");

        string line = reader.ReadLine();
        List<string> arr = new List<string>();

        using(reader)
        {
            while (line != null)
            {
                arr.Add(line);
                line = reader.ReadLine();
            }
        }

        arr.Sort();

        StreamWriter writer = new StreamWriter("Write.txt");

        using (writer)
        {
            foreach (string item in arr)
            {
                writer.WriteLine(item);
            }
        }
    }
}
