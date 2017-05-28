using System;
using System.Text;
using System.Numerics;

class HelpDog
{
    static BigInteger[,] matrix;
    static int fx;
    static int fy;


    static void Main()
    {
        Input();
        var result = FindAllPaths();
        Console.WriteLine(result);
    }

    static void Input()
    {
        string[] sizeOfMatrix = Console.ReadLine().Split(new char[] { ' ' });
        matrix = new BigInteger[int.Parse(sizeOfMatrix[0]), int.Parse(sizeOfMatrix[1])];

        string[] boneCoordinates = Console.ReadLine().Split(new char[] { ' ' });
        fx = int.Parse(boneCoordinates[0]);
        fy = int.Parse(boneCoordinates[1]);

        int countOfEnemys = int.Parse(Console.ReadLine());
        for (int i = 0; i < countOfEnemys; i++)
        {
            string[] enemyCoordinates = Console.ReadLine().Split(new char[] { ' ' });
            matrix[int.Parse(enemyCoordinates[0]), int.Parse(enemyCoordinates[1])] = -1;
        }
    }

    private static BigInteger FindAllPaths()
    {
        if (matrix.GetLength(0) == 1 && matrix.GetLength(1) == 1)
        {
            return 1;
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if(matrix[0, col] == -1)
            {
                while (col < matrix.GetLength(1))
                {
                    matrix[0, col] = 0;
                    col++;
                }
            }
            else
            {
                matrix[0, col] = 1;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (matrix[row, 0] == -1)
            {
                while (row < matrix.GetLength(0))
                {
                    matrix[row, 0] = 0;
                    row++;
                }
            }
            else
            {
                matrix[row, 0] = 1;
            }
        }

        for (int row = 1; row < matrix.GetLength(0); row++)
        {
            for (int col = 1; col < matrix.GetLength(1); col++)
            {   
                if(matrix[row, col] == -1)
                {
                    matrix[row, col] = 0;
                }
                else
                {
                    matrix[row, col] = matrix[row - 1, col] + matrix[row, col - 1];

                    if(row == fx && col == fy)
                    {
                        return matrix[row, col];
                    }
                }
            }
        }
        return 0;
    }
    
}
