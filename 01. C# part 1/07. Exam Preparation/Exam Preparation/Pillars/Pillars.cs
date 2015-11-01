using System;
class Pillars
{
    static void Main()
    {
        int len = 8;
        int[,] matrix = new int[len, len];
        int counterOnes = 0;

        for (int row = 0; row < len; row++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int col = 0; col < len; col++)
            {
                int mask = 1 << col;
                int bit = (number & mask) >> col;

                if (bit == 1)
                {
                    matrix[row, col] = 1;
                    counterOnes++;
                }
            }
        }

        int counterOnesInCol = 0;
        int saveCountOnes = 0;
        bool noPillar = true;


        for (int col = len - 1; col >= 0; col--)
        {
            for (int row = 0; row < len; row++)
            {
                if(matrix[row, col] == 1)
                {
                    counterOnesInCol++;
                }
            }

            if ((2 * saveCountOnes) + counterOnesInCol == counterOnes)
            {
                Console.WriteLine("{0}", col);
                Console.WriteLine("{0}", saveCountOnes);
                noPillar = false;
                break;
            }

            saveCountOnes += counterOnesInCol;
            counterOnesInCol = 0;
        }
    
        if (noPillar)
        {
            Console.WriteLine("No");
        }
    }
}
