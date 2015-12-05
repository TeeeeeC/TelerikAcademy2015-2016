namespace Salaries
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static bool[,] graph;
        private static List<string> commands;
        private static long[] memo;
        private static int nodesCount;

        static void Main()
        {
            nodesCount = int.Parse(Console.ReadLine());
            graph = new bool[nodesCount, nodesCount];
            memo = new long[nodesCount];
            commands = new List<string>();
            for (int i = 0; i < nodesCount; i++)
            {
                var line = Console.ReadLine();
                commands.Add(line);
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'Y')
                    {
                        graph[i, j] = true;
                    }
                }
            }

            long result = 0;
            for (int i = 0; i < nodesCount; i++)
            {
                result += Dfs(i);
            }

            Console.WriteLine(result);
        }

        private static long Dfs(int node)
        {
            if (memo[node] > 0)
            {
                return memo[node];
            }

            long result = 0;
            for (int i = 0; i < nodesCount; i++)
            {
                if (graph[node, i])
                {
                    result += Dfs(i);
                }
            }

            if (result == 0)
            {
                result = 1;
            }

            memo[node] = result;
            return result;
        }
    }
}
