namespace Brackets
{
    using System;

    class Program
    {
        static void Main()
        {
            var sequence = Console.ReadLine();
            var len = sequence.Length + 1;
            var d = new long[len, len];
            d[0, 0] = 1;

            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (sequence[i - 1] == '(')
                    {
                        if (j == 0)
                        {
                            continue;
                        }
                        d[i, j] = d[i - 1, j - 1];
                    }
                    else if (sequence[i - 1] == ')')
                    {
                        d[i, j] = d[i - 1, j + 1];
                    }
                    else
                    {
                        if (j == 0)
                        {
                            d[i, j] = d[i - 1, j + 1];
                        }
                        else
                        {
                            d[i, j] = d[i - 1, j - 1] + d[i - 1, j + 1];
                        }

                    }
                }
            }


            Console.WriteLine(d[len - 1, 0]);
        }
    }
}
