using System;
using System.Text;

class NaBabaMiSmetalnika
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());

        int[,] smetalo = new int[8, width];

        for (int i = 0; i < 8; i++)
        {
            int num = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(num, 2).PadLeft(width, '0'); ;

            for (int j = 0; j < width; j++)
            {
                int bit = binary[j] - '0';

                if (bit == 1)
                {
                    smetalo[i, j] = 1;
                }
            }
        }

        long result = 0;
        string command = string.Empty;
        StringBuilder sb = new StringBuilder();
        int row = 0, col = 0;
        int countEmptyCols = 0;

        while (true)
        {
            command = Console.ReadLine();

            if (command == "stop")
            {
                for (int i = 0; i < 8; i++) // Sum of all 8 integer numbers
                {
                    for (int j = 0; j < width; j++)
                    {
                        sb.Append(smetalo[i, j]);
                    }
                    result += Convert.ToInt64(sb.ToString().PadLeft(width, '0'), 2);
                    sb.Clear();
                }

                for (int i = 0; i < width; i++) // Check for empty cols
                {
                    bool isEmptyCol = true;

                    for (int j = 0; j < 8; j++)
                    {
                        if (smetalo[j, i] == 1)
                        {
                            isEmptyCol = false;
                            break;
                        }
                    }

                    if(isEmptyCol)
                    {
                        countEmptyCols++;
                    }
                }

                result *= (long)countEmptyCols;
                break;
            }

            if (command != "reset")
            {
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());

                if (col < 0)
                {
                    col = 0;
                }

                if (col > width - 1)
                {
                    col = width - 1;
                }
            }

            if (command == "right")
            {
                int onesInRowForMoveRight = 0;

                while (col < width)
                {
                    if (smetalo[row, col] == 1)
                    {
                        onesInRowForMoveRight++;
                        smetalo[row, col] = 0;
                    }

                    col++;
                }

                for (int i = width - 1; i > width - onesInRowForMoveRight - 1; i--)
                {
                    smetalo[row, i] = 1;
                }
            }
            else if (command == "left")
            {
                int onesInRowForMoveLeft = 0;

                while (col >= 0)
                {
                    if (smetalo[row, col] == 1)
                    {
                        onesInRowForMoveLeft++;
                        smetalo[row, col] = 0;
                    }

                    col--;
                }

                for (int i = 0; i < onesInRowForMoveLeft; i++)
                {
                    smetalo[row, i] = 1;
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    int allOnesLeft = 0;

                    for (int j = 0; j < width; j++)
                    {
                        if (smetalo[i, j] == 1)
                        {
                            allOnesLeft++;
                            smetalo[i, j] = 0;
                        }

                        if (j == width - 1)
                        {
                            for (int p = 0; p < allOnesLeft; p++)
                            {
                                smetalo[i, p] = 1;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(result);
    }
}
