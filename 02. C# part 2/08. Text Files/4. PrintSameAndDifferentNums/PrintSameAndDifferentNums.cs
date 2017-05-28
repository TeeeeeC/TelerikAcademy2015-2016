using System;
using System.IO;

class PrintSameAndDifferentNums
{
    static void Main()
    {
        /*
         Problem 4. Compare text files
             Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
             Assume the files have equal number of lines.
         */
        StreamReader readerFile1 = new StreamReader("text1.txt");
        StreamReader readerFile2 = new StreamReader("text2.txt");

        int countSameLines = 0, countDiffLines = 0;

        using(readerFile1)
        {
            using (readerFile2)
            {
                string lineOfFile1 = readerFile1.ReadLine();
                string lineOfFile2 = readerFile2.ReadLine();

                while(lineOfFile1 != null && lineOfFile2 != null)
                {
                    if (lineOfFile1 == lineOfFile2)
                    {
                        countSameLines++;
                    }
                    else
                    {
                        countDiffLines++;
                    }

                    lineOfFile1 = readerFile1.ReadLine();
                    lineOfFile2 = readerFile2.ReadLine();
                }
            }
        }

        Console.WriteLine("Same lines are {0}.\nDifferent lines are {1}.", countSameLines, countDiffLines);
    }
}
