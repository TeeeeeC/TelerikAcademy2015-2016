using System;
using System.IO;
class FindMaxSum
{
    static void Main()
    {
        /*
         Problem 5. Maximal area sum
            Write a program that reads a text file containing a square matrix of numbers.
            Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
            The first line in the input file contains the size of matrix N.
            Each of the next N lines contain N numbers separated by space.
            The output should be a single number in a separate text file.
         */
        StreamReader reader = new StreamReader("Read.txt");

        string sizeMatrix = reader.ReadLine();
        int num = Convert.ToInt32(sizeMatrix);

        int[,] matrix = new int[num, num];
        int row = 0, col = 0;
        
        using(reader)
        {
            string lineOfMatrix = reader.ReadLine();

            while (lineOfMatrix != null)
            {
                int i = -1, startIndex = 0, len = 0;

                while (i != lineOfMatrix.Length - 1) 
                {
                    i++;
                    len++;
                    char ch = lineOfMatrix[i];

                    if (ch == ' ' || i == lineOfMatrix.Length - 1)
                    {
                        string numStr = lineOfMatrix.Substring(startIndex, len);

                        matrix[row, col] = Convert.ToInt32(numStr);
                        startIndex = i + 1;
                        col++;
                        len = 0;
                    }                    
                } 

                lineOfMatrix = reader.ReadLine();
                row++;
                col = 0;
            }
        }

        StreamWriter writer = new StreamWriter("Write.txt");

        using(writer)
        {
            int result = GetMaxSum(matrix, num, num);
            writer.WriteLine(result);
        }
    }

    private static int GetMaxSum(int[,] matrix, int rows, int cols)
    {
        int sum = 0, bestSum = 0;

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }

        return bestSum;
    }
}