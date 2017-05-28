namespace DataStructuresEfficiency.TaskCalculator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using Wintellect.PowerCollections;

    public class TaskCalculator
    {
        private const string SymbolsUsedForRandomStringGeneration = "0123456789";
        private const int ArticlesCount = 10000;

        private static Random rand = new Random();

        public void PrintCoursesWithStudents(string path)
        {
            var data = new SortedDictionary<string, List<string>>();
            using (var reader = new StreamReader(path))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var student = line.Split('|');
                    var name = student[0].Trim() + " " + student[1].Trim();
                    var course = student[2].Trim();
                    if (!data.ContainsKey(course))
                    {
                        data.Add(course, new List<string>());
                        data[course].Add(name);
                    }
                    else
                    {
                        data[course].Add(name);
                    }

                    line = reader.ReadLine();
                }
            }

            foreach (var course in data)
            {
                Console.WriteLine("{0}: {1}", course.Key, string.Join(", ", course.Value));
            }
        }

        public void FindArticleInPriceRange()
        {
            var data = new OrderedMultiDictionary<decimal, Article>(true);
            Console.WriteLine("Adding 10000 articles...");
            for (int i = 0; i < ArticlesCount; i++)
            {
                var article = new Article
                {
                    Barcode = this.GetRandomString(20, 20),
                    Price = rand.Next(1000, 10000),
                    Vendor = this.GetRandomString(5, 20),
                    Title = this.GetRandomString(5, 20)
                };

                if (!data.ContainsKey(article.Price))
                {
                    data.Add(article.Price, article);
                }
                else
                {
                    data[article.Price].Add(article);
                }
            }

            var articlesCollection = data.Range(3000, true, 6000, true);
            foreach (var article in articlesCollection)
            {
                Console.WriteLine("{0} products with {1} price", article.Value.Count, article.Key);
            }
        }

        public void TestBiDictionary()
        {
            var dictionary = new BiDictionary<int, string, int>();
            dictionary.Add(1, "Pesho", new List<int>() { 2, 3, 4 });
            dictionary.Add(2, "Gosho", new List<int>() { 6, 7, 8 });
            foreach (var data in dictionary)
            {
                Console.WriteLine("Key1: {0}, Key2: {1} -> Values: {2}", data.Key1, data.Key2, string.Join(", ", data.Value));
            }

            var values = dictionary.Find(2);
            Console.WriteLine("Found values with key = 2 -> {0}", string.Join(", ", values));
        }

        private string GetRandomString(int minLen, int maxLen)
        {
            var length = rand.Next(minLen, maxLen + 1);

            var output = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                var index = rand.Next(0, SymbolsUsedForRandomStringGeneration.Length);
                output.Append(SymbolsUsedForRandomStringGeneration[index]);
            }

            return output.ToString();
        }
    }
}
