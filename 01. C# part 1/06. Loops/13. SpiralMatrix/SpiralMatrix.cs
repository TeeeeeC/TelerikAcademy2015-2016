using System;

class SpiralMatrix
{
    static void Main()
    {
        /*
         Problem 19.** Spiral Matrix
            Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers 
            from 1 to n*n in the form of square spiral like in the examples below.
         */
        int numbers = int.Parse(Console.ReadLine());

        int[,] spiralMatrix = new int[numbers, numbers];  

        int number = 0;
        int row = 0;
        int col = 0;

        string direction = "right";

        while (true)
        {
            if (number == numbers * numbers)
            {
                break;
            }

            if (direction == "right")
            {
                number++;
                spiralMatrix[row, col] = number;
                col++;

                if (col == numbers - row)
                {
                    direction = "down";
                    col--;
                    continue;
                }
            }

            if (direction == "down")
            {
                number++;
                row++;
                spiralMatrix[row, col] = number;

                if (row == col)
                {
                    direction = "left";
                    continue;
                }
            }

            if (direction == "left")
            {
                number++;
                col--;
                spiralMatrix[row, col] = number;

                if (col == numbers - row - 1)
                {
                    direction = "up";
                    continue;
                }
                  
            }

            if (direction == "up")
            {
                if (row == col + 1)
                {
                    direction = "right";
                    col++;
                    continue;
                }

                number++;
                row--;
                spiralMatrix[row, col] = number;
                
            }
        }

        for (int i = 0; i < numbers; i++)
        {
            for (int j = 0; j < numbers; j++)
            {
                Console.Write("{0}", spiralMatrix[i, j]);

                if (spiralMatrix[i, j] < 10)
                {
                    Console.Write(new string(' ', 5));
                }
                else if (spiralMatrix[i, j] < 100)
                {
                    Console.Write(new string(' ', 4));
                }
                else
                {
                    Console.Write(new string(' ', 3));
                }
            }
            Console.WriteLine();
        }
    }   
}



