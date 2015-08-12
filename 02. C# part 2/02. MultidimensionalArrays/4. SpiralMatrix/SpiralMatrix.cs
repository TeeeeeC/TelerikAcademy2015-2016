using System;

class SpiralMatrix
{
    static void Main()
    {
        /*
        Problem 1d*. Fill the spiral matrix
           Write a program that fills and prints a matrix of size (n, n) as shown below:
        */
        int numbers = 0;
        Console.Write("Size of matrix[n, n]: ");
        string text = Console.ReadLine();
        int.TryParse(text, out numbers);

        int[,] spiralMatrix = new int[numbers, numbers];

        int number = 0;
        int row = 0;
        int col = 0;

        string direction = "down";

        while (true)
        {
            if (number == numbers * numbers)
            {
                break;
            }

            if (direction == "down")
            {
                number++;
                spiralMatrix[row, col] = number;
                row++;

                if (row == numbers - col)
                {
                    direction = "right";
                    row--;
                    continue;
                }
            }

            if (direction == "right")
            { 
                number++;
                col++;
                spiralMatrix[row, col] = number;

                if (col == row)
                {
                    direction = "up";
                    continue;
                }
            }

            if (direction == "up")
            {
                number++;
                row--;
                spiralMatrix[row, col] = number;

                if (row == numbers - col - 1)
                {
                    direction = "left";
                    continue;
                }

            }

            if (direction == "left")
            {
                if (col == row + 1)
                {
                    direction = "down";
                    row++;
                    continue;
                }

                number++;
                col--;
                spiralMatrix[row, col] = number;

            }
        }

        for (int i = 0; i < numbers; i++)
        {
            for (int j = 0; j < numbers; j++)
            {
                Console.Write(Convert.ToString(spiralMatrix[i, j]).PadRight(5, ' '));
            }
            Console.WriteLine();
        }
    }
}
