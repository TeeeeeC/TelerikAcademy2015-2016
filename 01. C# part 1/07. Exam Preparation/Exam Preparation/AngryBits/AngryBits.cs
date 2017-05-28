using System;

class AngryBits
{
    static void Main()
    {
        int[,] matrix = new int[8, 16];

        for (int i = 0; i < 8; i++)
        {
            ushort num = ushort.Parse(Console.ReadLine());

            for (int j = 0; j < 16; j++)
            {
                int bit = (num & (1 << j)) >> j;

                if (bit == 1)
                {
                    matrix[i, j] = 1;
                }
            }
        }

        int pathBird = 0;
        int hittenPig = 0;
        int row = 0, col = 8;
        int oldRow = 0, oldCol = 8;
        int result = 0;
        string direction = "up";
        bool existPigs = false;

        while(true)
        {
            if (oldRow == 7 && oldCol == 15 && matrix[oldRow, oldCol] == 0)
            {
                break;
            }

            row = oldRow;
            col = oldCol;

            if (matrix[row, col] == 1)
            {
                matrix[row, col] = 0;

                while (true)
                {
                    if (row > 0 && direction == "up")
                    {
                        row--;
                        col--;
                        pathBird++;
                    }
                    else
                    {
                        direction = "down";
                        row++;
                        col--;
                        pathBird++;
                    }

                    if (row == 8 || col == -1)
                    {
                        break;
                    }

                    if (matrix[row, col] == 1)
                    {
                        matrix[row, col] = 0;
                        hittenPig++;
                        existPigs = true;

                        if (row < 7 && row > 0 && col > 0)
                        {
                            if (matrix[row + 1, col + 1] == 1)
                            {
                                matrix[row + 1, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row, col + 1] == 1)
                            {
                                matrix[row, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col + 1] == 1)
                            {
                                matrix[row - 1, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col] == 1)
                            {
                                matrix[row - 1, col] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col - 1] == 1)
                            {
                                matrix[row - 1, col - 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row, col - 1] == 1)
                            {
                                matrix[row, col - 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col - 1] == 1)
                            {
                                matrix[row + 1, col - 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col] == 1)
                            {
                                matrix[row + 1, col] = 0;
                                hittenPig++;
                            }
                        }
                        else if (row == 7 && col == 0)
                        {
                            if (matrix[row, col + 1] == 1)
                            {
                                matrix[row, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col + 1] == 1)
                            {
                                matrix[row - 1, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col] == 1)
                            {
                                matrix[row - 1, col] = 0;
                                hittenPig++;
                            }
                        }
                        else if (row == 0 && col == 0)
                        {
                            if (matrix[row, col + 1] == 1)
                            {
                                matrix[row, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col + 1] == 1)
                            {
                                matrix[row + 1, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col] == 1)
                            {
                                matrix[row + 1, col] = 0;
                                hittenPig++;
                            }
                        }
                        else if (row == 7)
                        {
                            if (matrix[row, col + 1] == 1)
                            {
                                matrix[row, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col + 1] == 1)
                            {
                                matrix[row - 1, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col] == 1)
                            {
                                matrix[row - 1, col] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col - 1] == 1)
                            {
                                matrix[row - 1, col - 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row, col - 1] == 1)
                            {
                                matrix[row, col - 1] = 0;
                                hittenPig++;
                            }
                        }
                        else if (col == 0)
                        {
                            if (matrix[row - 1, col] == 1)
                            {
                                matrix[row - 1, col] = 0;
                                hittenPig++;
                            }
                            if (matrix[row - 1, col + 1] == 1)
                            {
                                matrix[row - 1, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row, col + 1] == 1)
                            {
                                matrix[row, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col + 1] == 1)
                            {
                                matrix[row + 1, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col] == 1)
                            {
                                matrix[row + 1, col] = 0;
                                hittenPig++;
                            }
                        }
                        else if (row == 0)
                        {
                            if (matrix[row, col + 1] == 1)
                            {
                                matrix[row, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col + 1] == 1)
                            {
                                matrix[row + 1, col + 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col] == 1)
                            {
                                matrix[row + 1, col] = 0;
                                hittenPig++;
                            }
                            if (matrix[row + 1, col - 1] == 1)
                            {
                                matrix[row + 1, col - 1] = 0;
                                hittenPig++;
                            }
                            if (matrix[row, col - 1] == 1)
                            {
                                matrix[row, col - 1] = 0;
                                hittenPig++;
                            }
                        }

                        result += hittenPig * pathBird;
                        direction = "up";
                        break;
                    }
                }  
            }

            if (oldRow == 7 && oldCol == 15)
            {
                break;
            }
                
            oldRow++;
            hittenPig = 0;
            pathBird = 0;

            if (oldRow == 8)
            {
                oldRow = 0;
                oldCol++;
            }
        }


        bool win = true;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[i, j] == 1)
                {
                    win = false;
                    break;
                }
            }
        }
        
        if (win && existPigs)
        {
            Console.WriteLine(result + " Yes");
        }
        else
        {
            Console.WriteLine(result + " No");
        }
    }
}
