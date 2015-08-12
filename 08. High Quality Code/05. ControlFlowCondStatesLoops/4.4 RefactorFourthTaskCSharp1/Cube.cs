namespace _4._4_RefactorFourthTaskCSharp1
{
    using System;

    public class Cube
    {
        public static void Main(string[] args)
        {
            int sizeOfCube = int.Parse(Console.ReadLine());

            PrintCube(sizeOfCube);
        }

        private static void PrintCube(int sizeOfCube)
        {
            for (int row = 0; row < sizeOfCube; row++)
            {
                for (int column = 0; column < sizeOfCube * 2; column++)
                {
                    if (column < sizeOfCube - row)
                    {
                        Console.Write(" ");
                    }
                    else if (row == 0)
                    {
                        Console.Write(":");
                    }
                    else if (row > 1 && column >= (2 * sizeOfCube) - row && column < (2 * sizeOfCube) - 1)
                    {
                        Console.Write("X");
                    }
                    else if (column == (2 * sizeOfCube) - 1 || (row == sizeOfCube - 1 && column < sizeOfCube))
                    {
                        Console.Write(":");
                    }
                    else if (column == sizeOfCube - row || column == (2 * sizeOfCube) - 1 - row)
                    {
                        Console.Write(":");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }

                Console.WriteLine();
            }

            ////Second Part
            for (int row = 0; row < sizeOfCube - 1; row++)
            {
                for (int col = 0; col < (2 * sizeOfCube) - 1; col++)
                {
                    if (col > (2 * sizeOfCube) - row - 2 || col == 0 || (col > 1 && col < sizeOfCube && row != sizeOfCube - 2))
                    {
                        Console.Write(" ");
                    }
                    else if (col > sizeOfCube && col < (2 * sizeOfCube) - row - 2 && row < sizeOfCube - 3)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(":");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
