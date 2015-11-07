namespace AdvancedDataStructures.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Tasks;
    using Tasks.Tries;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            // 1.
            var priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(2);
            priorityQueue.Enqueue(7);
            priorityQueue.Enqueue(17);
            priorityQueue.Enqueue(19);
            priorityQueue.Enqueue(26);
            priorityQueue.Enqueue(29);
            priorityQueue.Dequeue();
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(1);
            priorityQueue.Dequeue();
            priorityQueue.Enqueue(25);
            priorityQueue.Enqueue(36);
            priorityQueue.Dequeue();

            Console.WriteLine();

            // 2.
            PrintFirst20Products();

            Console.WriteLine();

            // 3.
            CountWords();

        }

        private static void PrintFirst20Products()
        {
            var rand = new Random();
            var orderedBag = new OrderedBag<Product>((pr, pr1) => pr.Price.CompareTo(pr1.Price));
            var start = DateTime.Now;
            for (int i = 0; i < 500000; i++)
            {
                var product = new Product
                {
                    Name = "Product" + (i + 1),
                    Price = rand.Next(1000, 50000)
                };

                orderedBag.Add(product);
            }

            for (int i = 0; i < 10000; i++)
            {
                var initialPrice = rand.Next(1000, 50000);
                var products = orderedBag.Range(new Product { Price = initialPrice }, true, new Product { Price = initialPrice + 20000 }, true).Take(20).ToList();
                foreach (var prod in products)
                {
                    Console.WriteLine("{0}->{1}", prod.Name, prod.Price);
                }
            }
            Console.WriteLine(DateTime.Now - start);
        }

        private static void CountWords()
        {
            using (var reader = new StreamReader(@"..\..\text.txt"))
            {
                Console.Write("Reading 100MB file.");
                var line = reader.ReadLine().ToLower();
                List<string> allWords = line.Split(new char[] { ' ', '!', '?', ',', ';', ':', '-', '(', ')', '\\', '.' },
                        StringSplitOptions.RemoveEmptyEntries).ToList();
                var trie = TrieFactory.GetTrie();
                while (line != null)
                {
                    var words = line.Split(new char[] { ' ', '!', '?', ',', ';', ':', '-', '(', ')', '\\', '.' },
                        StringSplitOptions.RemoveEmptyEntries).ToList();
                    allWords.AddRange(words);
                    line = reader.ReadLine();
                    Console.Write(".");
                }

                foreach (var word in allWords)
                {
                    trie.AddWord(word);
                }

                Console.WriteLine();
                var start = DateTime.Now;
                Console.WriteLine("Start searching...");
                var rand = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    var currWord = allWords[rand.Next(0, allWords.Count)];
                    Console.WriteLine("{0}->{1}", currWord, trie.WordCount(currWord));
                }

                Console.WriteLine("Time elapsed: {0}", DateTime.Now - start);
            }
        }
    }
}
