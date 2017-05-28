using System;

class FirTree
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int center = number - 2;
        int line = (number - 1) * 2;
        bool finalLine = false;

        for (int row = 0; row < number; row++)
        {
            for (int col = 0; col < line - 1; col++)
            {
                if (row == number - 1)
                {
                    row = 0;
                    finalLine = true;
                }

                if (col >= center - row && col <= line - number + row)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();

            if(finalLine)
            {
                break;
            }
        }
    }
}
