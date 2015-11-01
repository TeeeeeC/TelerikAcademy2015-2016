using System;

class UKfFlag
{
    static void Main()
    {
        int len = int.Parse(Console.ReadLine());
        int center = len / 2 + 1;

        for (int row = 0; row < center; row++)
        {
            for (int col = 0; col < len; col++)
            {
                if (row < center - 1)
                {
                    if (col == row)
                    {
                        Console.Write("\\");
                    }
                    else if (col == center - 1)
                    {
                        Console.Write("|");
                    }
                    else if (col == len - row - 1)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    if (col == center - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }

            Console.WriteLine();
        }

        for (int row = 0; row < center - 1; row++)
        {
            for (int col = 0; col < len; col++)
            {
                if (col == center - row - 2)
                {
                    Console.Write("/");
                }
                else if (col == center - 1)
                {
                    Console.Write("|");
                }
                else if (col == center + row)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}
