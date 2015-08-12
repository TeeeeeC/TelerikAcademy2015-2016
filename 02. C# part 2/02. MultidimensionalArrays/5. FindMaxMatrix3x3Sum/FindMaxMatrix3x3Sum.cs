using System;

class FindMaxMatrix3x3Sum
{
    static void Main()
    {
        /*
         Problem 2. Maximal sum
            Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
         */
        int rows = 0;

        Console.Write("Rows of array: ");
        string text = Console.ReadLine();
        int.TryParse(text, out rows);

        if (rows < 1)
        {
            rows = 4; //If user enter letter or negative number
        }

        int cols = 0;

        Console.Write("Cols of array: ");
        text = Console.ReadLine();
        int.TryParse(text, out cols);

        if (cols < 1)
        {
            cols = 6; //If user enter letter or negative number
        }

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int num = 0;
                Console.Write("matrix[{0}, {1}]: ", row, col);
                text = Console.ReadLine();
                int.TryParse(text, out num);
                matrix[row, col] = num;
            }
        }

        int maxSum = int.MinValue;
        int startRow = 0, startCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    startRow = row;
                    startCol = col;
                }
            }
        }

        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                Console.Write(Convert.ToString(matrix[row, col]).PadRight(5, ' '));
            }
            Console.WriteLine();
        }
    }
}
