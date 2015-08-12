using System;

class Eggcelent
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int cols = (num * 3) + 1;
        int centerCols = cols / 2;
        int counter = 1;

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                
                if (i == 0 && j > num && j < cols - num - 1)
                {
                    Console.Write("*");
                }
                else if (i == num - 1)
                {
                    if (j == 0 || j == cols - 1)
                    {
                        Console.Write(".");
                    }
                    else if (j == 1 || j == cols - 2)
                    {
                        Console.Write("*");
                    }
                    else 
                    {
                        if (j %2 == 0)
                        {
                            Console.Write("@");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                else if (i > 0 && i < num - 1)
                {
                    if (j == num - counter || j == cols - num + counter - 1)
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
                    Console.Write(".");
                }
            }
            Console.WriteLine();

            if (i < num / 2 && i > 0)
            {
                counter += 2;
            }
        }

        counter = 1;

        for (int i = num - 1; i >= 0; i--)
        {
            for (int j = 0; j < cols; j++)
            {

                if (i == 0 && j > num && j < cols - num - 1)
                {
                    Console.Write("*");
                }
                else if (i == num - 1)
                {
                    if (j == 0 || j == cols - 1)
                    {
                        Console.Write(".");
                    }
                    else if (j == 1 || j == cols - 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write("@");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                else if (i > 0 && i < num - 1)
                {
                    if (j == counter || j == cols - 1 - counter)
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
                    Console.Write(".");
                }
            }
            Console.WriteLine();

            if (i < (num / 2) + 1)
            {
                counter += 2;
            }
        }
    }
}
