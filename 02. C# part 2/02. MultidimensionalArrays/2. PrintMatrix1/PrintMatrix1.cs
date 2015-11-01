using System;

class PrintMatrix1
{
    static void Main()
    {
        /*
         Problem 1b. Fill the matrix
            Write a program that fills and prints a matrix of size (n, n) as shown below:
         */
        int n = 0;
        Console.Write("Size of matrix[n, n]: ");
        string text = Console.ReadLine();
        int.TryParse(text, out n);

        int[,] matrix = new int[n, n];

        int num = 1;
        int i = 0, j = 0;

        while(num !=  (n * n) + 1)
        {
            matrix[i, j] = num;
            num++;          

            if (j %2 == 0)
            {
                i++;
            }

            if (j % 2 == 1)
            {
                i--;
            }

            if (i == n)
            {
                j++;
                i--;
            }

            if (i == -1)
            {
                j++;
                i++;
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
