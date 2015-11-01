using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

class DeletesGivenPrefixWord
{
    static void Main()
    {
        /*
         Problem 11. Prefix "test"
            Write a program that deletes from a text file all words that start with the prefix test.
            Words contain only the symbols 0…9, a…z, A…Z, _.
         */
        StreamReader reader = new StreamReader("Read.txt");
        string pattern = @"\b((test)(?=\w+))";
        Regex reg = new Regex(pattern);
        string remove = string.Empty;
        List<string> updateFile = new List<string>();

        using(reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                string result = reg.Replace(line, remove);
                updateFile.Add(result);
                line = reader.ReadLine();
            }
        }

        File.WriteAllLines("Read.txt", new List<string>());

        StreamWriter writer = new StreamWriter("Read.txt");

        using(writer)
        {
            foreach(string item in updateFile)
            {
                writer.WriteLine(item);
            }
        }
    }
}
