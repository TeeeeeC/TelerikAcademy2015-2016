using System;
using System.IO;

class DescriptionOfStrings
{
    static void Main(string[] args)
    {
        /*
         Problem 1. Strings in C
            Describe the strings in C#.
            What is typical for the string data type?
            Describe the most important methods of the String class.
         */
        StreamReader reader = new StreamReader("DescriptionOfStrings.txt");

        using(reader)
        {
            string line = reader.ReadLine();
            Console.WriteLine(line);

            while(line != null)
            {
                line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
