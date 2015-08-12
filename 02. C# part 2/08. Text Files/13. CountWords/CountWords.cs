using System;
using System.IO;
using System.Collections.Generic;

class CountWords
{
    static void Main()
    {
        /*
         Problem 13. Count words
            Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
            The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
            Handle all possible exceptions in your methods.
         */

        StreamReader readText = new StreamReader("text.txt");
        StreamReader readWords = new StreamReader("words.txt");
        string text = string.Empty;

        Dictionary<string, int> dict = new Dictionary<string, int>();
 
        try
        {
            using(readText)
            {
                try
                {
                    string line = readText.ReadLine();
                    text = line + " ";

                    while(line != null)
                    {
                        line = readText.ReadLine();
                        text = text + line + " ";
                    }
                }
                catch (OutOfMemoryException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (IOException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            using (readWords)
            {
                try
                {
                    string line = readWords.ReadLine();
                    dict[line] = 0;

                    while (line != null)
                    {
                        line = readWords.ReadLine();
                        dict[line] = 0;
                    }
                }
                catch (OutOfMemoryException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (IOException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
        catch(FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine(exc.Message);
        }

        string[] textWords = text.Split(new char[] {' ', ',', '.', '!', ':', ';', '?'}, StringSplitOptions.RemoveEmptyEntries);

        foreach(var word in textWords)
        {
            foreach (var dictionary in dict)
            {
                if(word == dictionary.Key)
                {
                    dict[word] += 1;
                    break;
                }
            }
        }

        Dictionary<string, int> dictSortedDesc = new Dictionary<string, int>();
        int maxNum = int.MinValue;
        string key = string.Empty;

        while(dict.Count != 0)
        {
            foreach (var elem in dict)
            {
                if(elem.Value >= maxNum)
                {
                    maxNum = elem.Value;
                    key = elem.Key;
                }
            }

            dictSortedDesc[key] = maxNum;
            dict.Remove(key);
            maxNum = int.MinValue;
        }

        StreamWriter writer = new StreamWriter("result.txt");

        try
        {
            using (writer)
            {
                foreach (var elem in dictSortedDesc)
                {
                    writer.WriteLine("{0} -> {1} times", elem.Key, elem.Value);
                }
            }
        }
        catch (FormatException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
}
