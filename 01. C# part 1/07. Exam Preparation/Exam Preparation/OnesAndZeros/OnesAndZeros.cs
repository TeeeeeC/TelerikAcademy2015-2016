using System;

class OnesAndZeros
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string binaryNum = Convert.ToString(num, 2).PadLeft(32, '0');

        int index = 16;
        int digit = 0;

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 31; col++)
            {
                if (col %2 == 0)
                {
                    if (index <= 31)
                    {
                        digit = binaryNum[index] - '0';
                    }

                    index++;
                }

                if(col %2 == 1)
                {
                    Console.Write(".");
                }
                else if(digit == 0)
                {
                    switch(row)
                    {
                        case 0: Console.Write("###"); break;
                        case 1: Console.Write("#.#"); break;
                        case 2: Console.Write("#.#"); break;
                        case 3: Console.Write("#.#"); break;
                        case 4: Console.Write("###"); break;
                    }
                }
                else 
                {
                    switch (row)
                    {
                        case 0: Console.Write(".#."); break;
                        case 1: Console.Write("##."); break;
                        case 2: Console.Write(".#."); break;
                        case 3: Console.Write(".#."); break;
                        case 4: Console.Write("###"); break;
                    }
                }
            }
            Console.WriteLine();
            index = 16;
        }
    }
}
