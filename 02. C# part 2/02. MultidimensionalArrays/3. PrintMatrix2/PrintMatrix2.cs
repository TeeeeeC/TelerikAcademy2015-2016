using System;
class PrintMatrix2
{
    static void Main()
    {
        /*
        Problem 1c. Fill the matrix
           Write a program that fills and prints a matrix of size (n, n) as shown below:
        */
        int n = 0;
        Console.Write("Size of matrix[n, n]: ");
        string text = Console.ReadLine();
        int.TryParse(text, out n);

        int[,] matrix = new int[n, n];

        int row = n - 1, col = 0;
        int oldRow = 1, oldCol = 0;
        int num = 1;

        while (num != (n * n) + 1)
        {
            matrix[row, col] = num;
            num++;

            if (col == n - 1)
            {
                row = 0;
                oldCol++;
                col = oldCol;
                continue;
            }

            if (row == n - 1)
            {
                col = 0;
                oldRow++;
                row = n - oldRow;
            }
            else
            {
                row++; 
                col++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(Convert.ToString(matrix[i, j]).PadRight(5, ' '));
            }
            Console.WriteLine();
        }
    }
}
