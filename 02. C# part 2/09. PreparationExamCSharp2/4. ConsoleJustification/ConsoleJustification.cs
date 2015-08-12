using System;
using System.Collections.Generic;
using System.Text;

class ConsoleJustification
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        List<string> words = new List<string>();

        for (int i = 0; i < lines; i++)
        {
            string text = Console.ReadLine();
            words.AddRange(text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));
        }

        int currLen = 0;
        int startPrintLines = 0;
        int countWordsInLine = 0;
        StringBuilder outputLine = new StringBuilder();

        List<string> currWords = new List<string>();

        for (int i = 0; i < words.Count; i++)
        {
            currLen += words[i].Length;

            if(currLen <= width - countWordsInLine)
            {
                currWords.Add(words[i]);
                countWordsInLine++;

                if (i == words.Count - 1)
                {
                    int countSpices = width - currLen;

                    if (currWords.Count == 1)
                    {
                        outputLine.Append(currWords[0]);
                        Console.WriteLine(outputLine);
                    }
                    else
                    {
                        int addSpaces = countSpices % (countWordsInLine - 1);
                        int spaces = countSpices / (countWordsInLine - 1);

                        for (int j = 0; j < countWordsInLine; j++)
                        {
                            if (j < countWordsInLine - 1)
                            {
                                outputLine.Append(currWords[j] + new string(' ', spaces));

                                if (addSpaces > 0)
                                {
                                    outputLine.Append(' ');
                                    addSpaces--;
                                }
                            }
                            else
                            {
                                outputLine.Append(currWords[j]);
                            }
                        }

                        Console.WriteLine(outputLine);
                    }
                }
            }
            else
            {
                int countSpices = width - currLen + words[i].Length;

                if (currWords.Count == 1)
                {
                    outputLine.Append(currWords[0]);
                    Console.WriteLine(outputLine);
                }
                else
                {
                    int addSpaces = countSpices % (countWordsInLine - 1);
                    int spaces = countSpices / (countWordsInLine - 1);

                    for (int j = 0; j < countWordsInLine; j++)
                    {
                        if(j < countWordsInLine - 1)
                        {
                            outputLine.Append(currWords[j] + new string(' ', spaces));

                            if(addSpaces > 0)
                            {
                                outputLine.Append(' ');
                                addSpaces--;
                            }
                        }
                        else
                        {
                            outputLine.Append(currWords[j]);
                        }
                    }
                    
                    Console.WriteLine(outputLine);
                }

                startPrintLines = i;
                i--;
                currLen = 0;
                countWordsInLine = 0;
                currWords.Clear();
                outputLine.Clear();
            }
        }
    }
}