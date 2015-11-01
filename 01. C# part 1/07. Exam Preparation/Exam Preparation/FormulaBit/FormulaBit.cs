using System;

class FormulaBit
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int mask = 1 << j;
                int bit = (mask & num) >> j;

                if(bit == 1)
                {
                    matrix[i, j] = 1;
                }
            }
        }

        string direction = "down";
        string oldDirection = "left";

        int row = 0, col = 0;
        int countZeros = 0, countTurns = 0;

        bool foundExit = false;

        while (true)
        {
            if (matrix[row, col] == 1)
            {
                break;
            }

            countZeros++;

            if (row == 7  && col == 7)
            {
                foundExit = true;
                break;
            }


            if (direction == "down" && (row + 1 > 7 || matrix[row + 1, col] == 1))
            {
                direction = "left";
                oldDirection = "down";
                countTurns++;

                if (col + 1 > 7 || matrix[row, col + 1] == 1)
                {
                    break;
                }
            }
            else if (direction == "up" && (row - 1 < 0 || matrix[row - 1, col] == 1))
            {
                direction = "left";
                oldDirection = "up";
                countTurns++;

                if (col + 1 > 7 || matrix[row, col + 1] == 1)
                {
                    break;
                }
            }
            else if ((direction == "left" && oldDirection == "down") && (col + 1 > 7 || matrix[row, col + 1] == 1))
            {
                direction = "up";
                countTurns++;

                if (row - 1 < 0 || matrix[row - 1, col] == 1)
                {
                    break;
                }
            }
            else if ((direction == "left" && oldDirection == "up") && (col + 1 > 7 || matrix[row, col + 1] == 1))
            {
                direction = "down";
                countTurns++;

                if (row + 1 > 7 || matrix[row + 1, col] == 1)
                {
                    break;
                }
            }

            if(direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col++;
            }
            else if (direction == "up")
            {
                row--;
            }
        }

        if (foundExit)
        {
            Console.WriteLine("{0} {1}", countZeros, countTurns);
        }
        else
        {
            Console.WriteLine("No {0}", countZeros);
        }
    }
}
