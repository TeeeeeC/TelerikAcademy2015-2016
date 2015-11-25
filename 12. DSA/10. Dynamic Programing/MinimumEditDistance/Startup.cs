namespace MinimumEditDistance
{
    using System;

    class Startup
    {
        static void Main()
        {
            // test it in bgcoder - Telerik Algo Academy @ February 2014 (Dynamic Programming) / Problem 4
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            int rows = input.Length + 1;
            int columns = output.Length + 1;
            var matrix = new decimal[rows, columns];
            var addOne = 1.2M;
            var addZero = 1.1M;
            var delOne = 0.8M;
            var delZero = 0.9M;
            var replace = 1;

            for (int i = 1; i < columns; i++)
            {
                if (output[i - 1] == '0')
                {
                    matrix[0, i] = matrix[0, i - 1] + addZero;
                }
                else
                {
                    matrix[0, i] = matrix[0, i - 1] + addOne;
                }
            }

            for (int i = 1; i < rows; i++)
            {
                if (input[i - 1] == '0')
                {
                    matrix[i, 0] = matrix[i - 1, 0] + delZero;
                }
                else
                {
                    matrix[i, 0] = matrix[i - 1, 0] + delOne;
                }
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    if (input[i - 1] == output[j - 1])
                    {
                        if (output[j - 1] == '0')
                        {
                            matrix[i, j] = Math.Min(matrix[i, j - 1] + addZero,
                                Math.Min(matrix[i - 1, j - 1], matrix[i - 1, j] + delZero));
                        }
                        else
                        {
                            matrix[i, j] = Math.Min(matrix[i, j - 1] + addOne,
                                Math.Min(matrix[i - 1, j - 1], matrix[i - 1, j] + delOne));
                        }
                    }
                    else
                    {
                        if (output[j - 1] == '0')
                        {
                            matrix[i, j] = Math.Min(matrix[i, j - 1] + addZero,
                                Math.Min(matrix[i - 1, j - 1] + replace, matrix[i - 1, j] + delOne));
                        }
                        else
                        {
                            matrix[i, j] = Math.Min(matrix[i, j - 1] + addOne,
                                Math.Min(matrix[i - 1, j - 1] + replace, matrix[i - 1, j] + delZero));
                        }
                    }
                }
            }

            Console.WriteLine("{0:G29}", matrix[rows - 1, columns - 1]);
        }
    }
}
