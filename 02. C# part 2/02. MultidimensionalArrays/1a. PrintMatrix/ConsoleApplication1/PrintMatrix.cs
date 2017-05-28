using System;

class PrintMatrix
{
    static void Main()
    {
        /*
         Problem 1a. Fill the matrix
            Write a program that fills and prints a matrix of size (n, n) as shown below:
         */
        int n = 0;
        Console.Write("Size of matrix[n, n]: ");
        string text = Console.ReadLine();
        int.TryParse(text, out n);

        int[,] matrix = new int[n, n];

        int num = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = num;
                num++;
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(Convert.ToString(matrix[row, col]).PadRight(5, ' '));
            }
            Console.WriteLine();
        }
    }
}
