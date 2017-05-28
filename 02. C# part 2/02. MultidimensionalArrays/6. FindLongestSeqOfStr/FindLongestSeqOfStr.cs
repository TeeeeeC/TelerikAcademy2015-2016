using System;

class FindLongestSeqOfStr
{
    static void Main()
    {
        /*
         Problem 3. Sequence n matrix
            We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
            Write a program that finds the longest sequence of equal strings in the matrix.
         */
        string[,] matrix = {
                               {"ha", "fifi", "ho", "hi"},
                               {"fo", "xx", "hi", "xp"},
                               {"xxx", "hi", "fipfi", "fifi"}
                           };

        int count = 1, longestLen = 1;
        string sequence = string.Empty;

        while (true)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        count++;

                        if (count > longestLen)
                        {
                            longestLen = count;
                            sequence = matrix[i, j];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
                count = 1;
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0) - 1; j++)
                {
                    if (matrix[j, i] == matrix[j + 1, i])
                    {
                        count++;

                        if (count > longestLen)
                        {
                            longestLen = count;
                            sequence = matrix[j, i];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
                count = 1;
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int k = 1;
                    count = 1;

                    while (matrix[i, j] == matrix[i + k, j + k])
                    {
                        count++;

                        if (count > longestLen)
                        {
                            longestLen = count;
                            sequence = matrix[i, j];
                        }

                        if (i + k < matrix.GetLength(0) - 1 && j + k < matrix.GetLength(1) - 1)
                        {
                            k++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                count = 1;
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = matrix.GetLength(1) - 1; j > 0; j--)
                {
                    int k = 1;
                    count = 1;

                    while (matrix[i, j] == matrix[i + k, j - k])
                    {
                        count++;

                        if (count > longestLen)
                        {
                            longestLen = count;
                            sequence = matrix[i, j];
                        }

                        if (i + k < matrix.GetLength(0) - 1 && j - k > 0)
                        {
                            k++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                count = 1;
            }

            break;
        }

        for (int p = 0; p < longestLen; p++)
        {
            Console.Write("{0}, ", sequence);
        }
        Console.WriteLine();
    }
}