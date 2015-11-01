using System;
class SandGlass
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int center = num / 2;
        int counter =  - center;

        for (int row = 0; row < num; row++)
        {
            for (int col = 0; col < num; col++)
            {
                if (row <= center)
                {
                    if (col >= row && col <= num - row - 1)
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
                    if (col >= center - counter && col <= center + counter)
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
            counter++;
        }
    }
}
