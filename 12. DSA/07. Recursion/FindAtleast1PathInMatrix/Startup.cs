namespace FindAtleast1PathInMatrix
{
    using System;

    public class Startup
    {
        private static int[,] matrix;


        private static void Main()
        {
            matrix = new int[100, 100];
            matrix[99, 99] = 1;
            PrintAllPaths(0, 0);
        }

        private static void PrintAllPaths(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0)
                || col < 0 || col >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[row, col] == 1)
            {
                Console.WriteLine("Path found!");
                Environment.Exit(0);
            }

            if (matrix[row, col] == -1)
            {
                return;
            }

            matrix[row, col] = -1;
            PrintAllPaths(row - 1, col);
            PrintAllPaths(row, col + 1);
            PrintAllPaths(row + 1, col);
            PrintAllPaths(row, col - 1);
        }
    }
}
