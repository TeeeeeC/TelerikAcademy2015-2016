namespace PrintAllPathsInMatrix
{
    using System;

    public class Startup
    {
        private static char[,] matrix =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

        private static void Main()
        {
            PrintAllPaths(0, 0);
        }

        private static void PrintAllPaths(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0)
                || col < 0 || col >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[row, col] == 'e')
            {
                Console.WriteLine("Path found!");
                return;
            }

            if (matrix[row, col] == '*' || matrix[row, col] == 'u')
            {
                return;
            }

            matrix[row, col] = 'u';
            PrintAllPaths(row - 1, col);
            PrintAllPaths(row, col + 1);
            PrintAllPaths(row + 1, col);
            PrintAllPaths(row, col - 1);
            matrix[row, col] = ' ';
        }
    }
}
