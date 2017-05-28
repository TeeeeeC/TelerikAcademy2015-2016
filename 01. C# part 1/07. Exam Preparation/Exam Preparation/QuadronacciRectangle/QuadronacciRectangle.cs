using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long num1 = long.Parse(Console.ReadLine());
        long num2 = long.Parse(Console.ReadLine());
        long num3 = long.Parse(Console.ReadLine());
        long num4 = long.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        long result = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == 0 && j < 4)
                {
                    switch(j)
                    {
                        case 0: Console.Write("{0} ", num1); break;
                        case 1: Console.Write("{0} ", num2); break;
                        case 2: Console.Write("{0} ", num3); break;
                        case 3: Console.Write("{0} ", num4); break;
                    }
                }
                else
                {
                    result = num1 + num2 + num3 + num4;

                    Console.Write("{0} ", result);

                    num1 = num2;
                    num2 = num3;
                    num3 = num4;
                    num4 = result;
                }
            }

            Console.WriteLine();
        }
    }
}
