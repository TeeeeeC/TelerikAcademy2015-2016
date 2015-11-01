namespace DictionariesSets.TasksCalculator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class TasksCalculator
    {
        public void CountDoubleValuesInArray(double[] numbers)
        {
            var dict = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 1);
                }
                else
                {
                    dict[number] += 1;
                }
            }

            foreach (var currNumber in dict)
            {
                Console.WriteLine("{0} -> {1} times", currNumber.Key, currNumber.Value);
            }

            Console.WriteLine();
        }

        public void ExtractAllElementThatPresentOddTimes(string[] words)
        {
            var dict = new SortedDictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                }
                else
                {
                    dict[word] += 1;
                }
            }

            var result = new HashSet<string>();
            foreach (var currWord in dict)
            {
                if (currWord.Value % 2 == 1)
                {
                    result.Add(currWord.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine();
        }

        public void CountWordsInTextFile(string path)
        {
            var reader = new StreamReader(path);
            var words = new SortedDictionary<string, int>();
            using (reader)
            {
                var line = reader.ReadLine().ToLower();
                while (line != null)
                {
                    var length = line.Length;
                    var word = new StringBuilder();
                    for (int i = 0; i < length; i++)
                    {
                        var symbol = line[i];
                        if (char.IsLetter(symbol))
                        {
                            word.Append(symbol);
                        }
                        else
                        {
                            if (word.Length > 0)
                            {
                                var wordAsString = word.ToString();
                                if (!words.ContainsKey(wordAsString))
                                {
                                    words.Add(wordAsString, 1);
                                }
                                else
                                {
                                    words[wordAsString] += 1;
                                }
                            }

                            word.Clear();
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            var sortedWordsByValue = words.OrderBy(w => w.Value).ToList();
            foreach (var word in sortedWordsByValue)
            {
                Console.WriteLine(word.Key + " -> " + word.Value);
            }

            Console.WriteLine();
        }
    }
}
