namespace SuperSum
{
    using System;

    class Startup
    {
        static void Main()
        {
            var parameters = Console.ReadLine().Split(' ');
            var k = int.Parse(parameters[0]);
            var n = int.Parse(parameters[1]);
            var backtracking = new int[k + 1, n + 1];
            backtracking[1, 1] = 1;
            for (int i = 2; i <= n; i++)
            {
                backtracking[1, i] = backtracking[1, i - 1] + i;
            }

            for (int i = 2; i <= k; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int l = 1; l <= j; l++)
                    {
                        backtracking[i, j] += backtracking[i - 1, l] ;
                    }
                    
                }
            }

            long result = 0;
            for (int i = 1; i <= n; i++)
            {
               result += backtracking[k - 1, i];
            }

            if (k > 1)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(backtracking[k, n]);
            }
        }
    }
}
