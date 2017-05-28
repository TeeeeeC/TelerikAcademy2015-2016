using System;
using System.IO;

class ReadAndPrintTextFile
{
    static void Main()
    {
        /*
         Problem 1. Odd lines
            Write a program that reads a text file and prints on the console its odd lines.
         */
        StreamReader reader = new StreamReader("text.txt");

        using (reader)
        {
            int oddLine = 1;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (oddLine % 2 == 1)
                {
                    Console.WriteLine("Oddlines {0}: {1}",oddLine, line);
                }

                oddLine++;
                line = reader.ReadLine();
            }
        }
    }
}