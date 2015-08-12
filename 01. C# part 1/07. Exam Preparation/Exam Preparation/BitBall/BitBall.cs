using System;

class BitBall
{
    static void Main()
    {
        int[,] playField = new int[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 0; j < 8; j++)
            {
                int bit = (num & (1 << j)) >> j;

                if (bit == 1)
                {
                    playField[i, j] = 1;
                }
            }
        }

        for (int i = 0; i < 8; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 0; j < 8; j++)
            {
                int bit = (num & (1 << j)) >> j;

                if (bit == 1 && playField[i, j] == 0)
                {
                    playField[i, j] = 2;
                }
                else if (bit == 1 && playField[i, j] == 1)
                {
                    playField[i, j] = 0;
                }

            }
        }

        int topTeamScore = 0;
        int bottomTeamScore = 0;
        bool topGoal = false;
        bool bottomGoal = false;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (playField[col, row] == 1 && !topGoal)
                {
                    topGoal = true;
                }
                else if (playField[col, row] == 2 && !bottomGoal)
                {
                    bottomGoal = true;
                }

                if (topGoal && bottomGoal)
                {
                    topGoal = false;
                    bottomGoal = false;
                    break;
                }
                else if (topGoal)
                {
                    if (col == 7)
                    {
                        topTeamScore++;
                    }
                }
                else if (bottomGoal)
                {
                    if (col == 7)
                    {
                        bottomTeamScore++;
                    }
                }
            }

            topGoal = false;
            bottomGoal = false;
        }

        Console.WriteLine("{0}:{1}", topTeamScore, bottomTeamScore);
    }
}
