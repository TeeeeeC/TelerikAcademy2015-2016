namespace _02._3_FindPathSumInMatrix
{
    using System;
    using System.Text;

    public class PrintPathSumInMatrix
    {
        public static void Main(string[] args)
        {
            var fistLineInput = Console.ReadLine().Split(new char[] { ' ' });
            var rows = int.Parse(fistLineInput[0]);
            var columns = int.Parse(fistLineInput[1]);
            var moves = int.Parse(Console.ReadLine());

            long sum = FindPathSumInMatrix(rows, columns, moves);
            
            Console.WriteLine(sum);
        }

        private static long FindPathSumInMatrix(int rows, int columns, int moves)
        {
            var visitedCell = new bool[rows, columns];
            long sum = 0;
            var currentRow = rows - 1;
            var currentColumn = 0;
            for (int i = 0; i < moves; i++)
            {
                var currentLine = Console.ReadLine().Split(new char[] { ' ' });
                var currentCommand = currentLine[0];
                var stepsCount = int.Parse(currentLine[1]);

                for (int j = 0; j < stepsCount - 1; j++)
                {
                    if (currentCommand == "RU" || currentCommand == "UR")
                    {
                        if (currentRow > 0 && currentColumn < columns - 1)
                        {
                            currentRow--;
                            currentColumn++;
                            if (!visitedCell[currentRow, currentColumn])
                            {
                                sum += (rows - currentRow + currentColumn - 1) * 3;
                            }

                            visitedCell[currentRow, currentColumn] = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (currentCommand == "LU" || currentCommand == "UL")
                    {
                        if (currentRow > 0 && currentColumn > 0)
                        {
                            currentRow--;
                            currentColumn--;
                            if (!visitedCell[currentRow, currentColumn])
                            {
                                sum += (rows - currentRow + currentColumn - 1) * 3;
                            }

                            visitedCell[currentRow, currentColumn] = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (currentCommand == "LD" || currentCommand == "DL")
                    {
                        if (currentRow < rows - 1 && currentColumn > 0)
                        {
                            currentRow++;
                            currentColumn--;
                            if (!visitedCell[currentRow, currentColumn])
                            {
                                sum += (rows - currentRow + currentColumn - 1) * 3;
                            }

                            visitedCell[currentRow, currentColumn] = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (currentCommand == "RD" || currentCommand == "DR")
                    {
                        if (currentRow < rows - 1 && currentColumn < columns - 1)
                        {
                            currentRow++;
                            currentColumn++;
                            if (!visitedCell[currentRow, currentColumn])
                            {
                                sum += (rows - currentRow + currentColumn - 1) * 3;
                            }

                            visitedCell[currentRow, currentColumn] = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return sum;
        }
    }
}
