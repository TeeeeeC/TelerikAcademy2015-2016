namespace FindAllConnectedAreasOfAdjacentCells
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static string[,] matrix = new string[,]
        {
            {"0", "0", "0", "x", "0", "x"},
            {"0", "x", "0", "x", "0", "x"},
            {"0", "*", "x", "0", "x", "0"},
            {"0", "x", "0", "0", "0", "0"},
            {"0", "0", "0", "x", "x", "0"},
            {"0", "0", "0", "x", "0", "x"}
        };

        private static void Main()
        {
            var answer = TraverseBFS(2, 1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (answer[i, j] == "0")
                    {
                        answer[i, j] = "u";
                    }

                    Console.Write(answer[i, j].PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
        }

        private static string[,] TraverseBFS(int startRow, int startColumn)
        {
            var queue = new Queue<Index>();
            var root = new Index {Row = startRow, Column = startColumn, Value = 1};

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var currRoot = queue.Dequeue();
                matrix[currRoot.Row, currRoot.Column] = currRoot.Value.ToString();
                currRoot.Value++;

                if (currRoot.Row + 1 < matrix.GetLength(0) && matrix[currRoot.Row + 1, currRoot.Column] == "0")
                {
                    currRoot.Children.Add(new Index
                    {
                        Row = currRoot.Row + 1,
                        Column = currRoot.Column,
                        Value = currRoot.Value
                    });
                }

                if (currRoot.Row - 1 >= 0 && matrix[currRoot.Row - 1, currRoot.Column] == "0")
                {
                    currRoot.Children.Add(new Index
                    {
                        Row = currRoot.Row - 1,
                        Column = currRoot.Column,
                        Value = currRoot.Value
                    });
                }

                if (currRoot.Column + 1 < matrix.GetLength(0) && matrix[currRoot.Row, currRoot.Column + 1] == "0")
                {
                    currRoot.Children.Add(new Index
                    {
                        Row = currRoot.Row,
                        Column = currRoot.Column + 1,
                        Value = currRoot.Value
                    });
                }

                if (currRoot.Column - 1 >= 0 && matrix[currRoot.Row, currRoot.Column - 1] == "0")
                {
                    currRoot.Children.Add(new Index
                    {
                        Row = currRoot.Row,
                        Column = currRoot.Column - 1,
                        Value = currRoot.Value
                    });
                }

                foreach (var index in currRoot.Children)
                {
                    queue.Enqueue(index);
                }
            }

            return matrix;
        }
    }
}
