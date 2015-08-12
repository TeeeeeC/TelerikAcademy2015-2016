using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int cols = (2 * input) + 1;
        int rows = input + 1;
        int centerCols = input;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == rows - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    if (j == centerCols || j == centerCols - i || j == centerCols + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }
            Console.WriteLine();
        }

        if (input < 4)
        {
            rows = input;
        }
        else
        {
            rows = (6 + ((input - 3) / 2) * 3) - rows + 1;
        }

        for (int i = 1; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == rows - 1)
                {
                    if (j >= i && j <= cols - i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    if (j == centerCols || j == i || j == cols - i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
