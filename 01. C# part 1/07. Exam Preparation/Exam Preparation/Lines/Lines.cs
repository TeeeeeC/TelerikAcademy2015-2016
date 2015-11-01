using System;

class Lines
{
    static void Main()
    {
        int len = 8;
        int[,] matrix = new int[len, len];

        for (int i = 0; i < len; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 0; j < len; j++)
            {
                int mask = 1 << j;
                int bit = (num & mask) >> j;

                if (bit == 1)
                {
                    matrix[i, j] = 1;
                }
            }
        }

        int countOnes = 0;
        int maxLen = 0;

        for (int row = 0; row < len; row++)
        {
            for (int col = 0; col < len; col++)
            {
                if (matrix[row, col] == 1)
                {
                    countOnes++;

                    if (countOnes > maxLen)
                    {
                        maxLen = countOnes;
                    }
                }
                else
                {
                    countOnes = 0;
                }
            }

            countOnes = 0;
        }

        countOnes = 0;

        for (int row = 0; row < len; row++)
        {
            for (int col = 0; col < len; col++)
            {
                if (matrix[col, row] == 1)
                {
                    countOnes++;

                    if (countOnes > maxLen)
                    {
                        maxLen = countOnes;
                    }
                }
                else
                {
                    countOnes = 0;
                }
            }

            countOnes = 0;
        }

        //Count lines
        countOnes = 0;
        int countLines = 0;

        for (int row = 0; row < len; row++)
        {
            for (int col = 0; col < len; col++)
            {
                if (matrix[row, col] == 1)
                {
                    countOnes++;

                    if (countOnes == maxLen)
                    {
                        countLines++;
                    }
                }
                else
                {
                    countOnes = 0;
                }
            }

            countOnes = 0;
        }

        countOnes = 0;

        for (int row = 0; row < len; row++)
        {
            for (int col = 0; col < len; col++)
            {
                if (matrix[col, row] == 1)
                {
                    countOnes++;

                    if (countOnes == maxLen)
                    {
                        countLines++;
                    }
                }
                else
                {
                    countOnes = 0;
                }
            }

            countOnes = 0;
        }

        if (maxLen == 1)
        {
            countLines /= 2;
        }

        Console.WriteLine(maxLen);
        Console.WriteLine(countLines);
    }
}
