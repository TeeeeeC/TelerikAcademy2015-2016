namespace DogeCoin
{
    using System;
    using System.Collections.Generic;

    internal class DogeCoin
    {
        internal static void Main()
        {
            var size = Console.ReadLine().Split(' ');
            var rows = int.Parse(size[0]);
            var cols = int.Parse(size[1]);

            var array = new int[rows, cols];
            PutCoins(array);

            var result = FindMaxCoinsCount(array, rows, cols);

            Console.WriteLine(result);
        }

        private static int FindMaxCoinsCount(int[,] array, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(row - 1 >= 0 && col - 1 >= 0)
                    {
                        array[row, col] += Math.Max(array[row - 1, col], array[row, col - 1]);
                    }
                    else if(row == 0 && col > 0)
                    {
                        array[row, col] += array[row, col - 1];
                    }
                    else if(col == 0 && row > 0)
                    {
                        array[row, col] += array[row - 1, col];
                    }
                }
            }

            return array[rows - 1, cols - 1];
        }

        private static void PutCoins(int[,] array)
        {
            var coinsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < coinsCount; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var row = int.Parse(line[0]);
                var col = int.Parse(line[1]);

                array[row, col] += 1;
            }
        }
    }
}
