using System;

class Pattern
{
    static int sizeOfArr;
    static int[,] matrix;
    static long maxSum = 0;
    static void Main()
    {
        Input(); 

        if(FindMaxSum())
        {
            Console.WriteLine("YES {0}", maxSum);
        }
        else
        {
            long mainDiagonaSum = FindMainDiagonalSum();
            Console.WriteLine("NO {0}", mainDiagonaSum);
        }
    }

    private static long FindMainDiagonalSum()
    {
        long diagonalSum = 0;
        int row = 0, col = 0;
        do
        {
            diagonalSum += matrix[row, col];
            row++;
            col++;
        }while(row != sizeOfArr || col != sizeOfArr);

        return diagonalSum;
    }

    private static bool FindMaxSum()
    {
        bool existPattern = false;
        for (int row = 0; row < sizeOfArr - 2; row++)
        {
            for (int col = 0; col < sizeOfArr - 4; col++)
            {
                int currRow = row;
                int currCol = col;
                int countPath = 0;

                long currSum = 0;
                int countRightDir = 0;
                while(countPath < 6)
                {
                    if(countPath < 2 || countPath > 3)
                    {
                        if (matrix[currRow, currCol] == matrix[currRow, currCol + 1] - 1)
                        {
                            if (countRightDir == 0)
                            {
                                currSum += matrix[currRow, currCol];
                            }
                            else
                            {
                                currSum += matrix[currRow, currCol + 1];
                            }
                            countPath++;
                            currCol++;

                            if(countPath == 2)
                            {
                                currSum += matrix[currRow, currCol];
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else 
                    {
                        if (matrix[currRow, currCol] == matrix[currRow + 1, currCol] - 1)
                        {
                            currSum += matrix[currRow + 1, currCol];
                            countPath++;
                            currRow++;

                            if(countPath == 4)
                            {
                                countRightDir++;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (countPath == 6 && currSum > maxSum)
                {
                    maxSum = currSum;
                    existPattern = true;
                }
            }
        }
        return existPattern;
    }

    private static void Input()
    {
        sizeOfArr = int.Parse(Console.ReadLine());
        matrix = new int[sizeOfArr, sizeOfArr];

        for (int row = 0; row < sizeOfArr; row++)
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < sizeOfArr; col++)
            {
                matrix[row, col] = int.Parse(line[col]);
            }
        }
    }
}
