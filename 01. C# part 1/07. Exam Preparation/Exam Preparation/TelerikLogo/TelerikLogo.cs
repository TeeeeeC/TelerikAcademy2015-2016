using System;

class TelerikLogo
{
    static void Main()
    {
        int numX = int.Parse(Console.ReadLine());
        int numZ = (numX / 2) + 1;

        int rows = (numX * 3) - 2;
        int cols = (numX * 3) - 2;
        int count = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row < (numX * 2) - 1)
                {
                    if ((col == numZ - row - 1 || col == numZ + row - 1) || (col == cols - numZ - row || col == cols - numZ + row))
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
                    if ((col == numZ + count || col == cols - numZ - count - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }

            if (row >= (numX * 2) - 1)
            {
                count++;
            }
            Console.WriteLine();
        }
    }
}
