namespace Knapsack
{
    using System;

    internal class Startup
    {
        internal static void Main()
        {
            // Test it in bgcoder - Telerik Algo Academy February 2014 (Dynamic Programming) - Problem 3 
            var maxSize = int.Parse(Console.ReadLine());
            var foodCount = int.Parse(Console.ReadLine());
            var foods = new Food[foodCount + 1];
            for (int i = 1; i <= foodCount; i++)
            {
                var line = Console.ReadLine().Split(' ');
                foods[i] = new Food() { Name = line[0], Weight = int.Parse(line[1]), Delicious = int.Parse(line[2]) };
            }

            var matrix = new int[foodCount + 1, maxSize + 1];
            for (int i = 1; i <= foodCount; i++)
            {
                for (int j = 1; j <= maxSize; j++)
                {
                    if (j - foods[i].Weight < 0)
                    {
                        matrix[i, j] = matrix[i - 1, j];
                    }
                    else
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j],
                            matrix[i - 1, j - foods[i].Weight] + foods[i].Delicious);
                    }
                }
            }

            Console.WriteLine(matrix[foodCount, maxSize]);

            int row = foodCount;
            int col = maxSize;
            while (matrix[row, col] != 0)
            {
                if (matrix[row - 1, col] != matrix[row, col])
                {
                    Console.WriteLine(foods[row].Name);
                    col = col - foods[row].Weight;
                    row--;
                }
                else
                {
                    row--;

                }
            }
        }
    }

    internal class Food
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Delicious { get; set; }
    }
}
