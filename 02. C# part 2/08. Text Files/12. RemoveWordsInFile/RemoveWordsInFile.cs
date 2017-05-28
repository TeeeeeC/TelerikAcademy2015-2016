using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

class RemoveWordsInFile
{
    static void Main()
    {
        /*
         Problem 12. Remove words
            Write a program that removes from a text file all words listed in given another text file.
            Handle all possible exceptions in your methods.
         */
        string pathFileWords = "words.txt";
        string pathFileText = "text.txt";
        List<string> words = new List<string>();
        List<string> updateTextFile = new List<string>();

        try
        {
            StreamReader readWords = new StreamReader(pathFileWords);
            Console.WriteLine("File {0} was successfully opened!", pathFileWords);

            using(readWords)
            {
                string line = readWords.ReadLine();

                while(line != null)
                {
                    words.Add(line);
                    line = readWords.ReadLine();   
                }
            }

            StreamReader readText = new StreamReader(pathFileText);
            Console.WriteLine("File {0} was successfully opened!", pathFileText);

            using (readText)
            {
                string row = readText.ReadLine();

                while (row != null)
                {
                    string updateLine = string.Empty;

                    for (int i = 0; i < words.Count; i++)
                    {
                        string pattern = @"(?=\b|\s)" + words[i] + @"(?=\b|\s)";
                        string remove = string.Empty;
                        Regex reg = new Regex(pattern);

                        updateLine = reg.Replace(row, remove);
                        row = updateLine;
                    }

                    updateTextFile.Add(updateLine);
                    row = readText.ReadLine();
                }
            }

            File.WriteAllLines(pathFileText, new string[] {""});

            StreamWriter writeUpdateText = new StreamWriter(pathFileText);

            using(writeUpdateText)
            {
                foreach(string item in updateTextFile)
                {
                    writeUpdateText.WriteLine(item);
                }
            }
        }
        catch(FileNotFoundException exc)
        {
            Console.WriteLine("File {0} is not found!", exc.FileName);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ObjectDisposedException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch
        {
            Console.WriteLine("Fatal error!");
        }

    }
}
