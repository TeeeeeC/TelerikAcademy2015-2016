namespace ZigZagSets
{
    using System;

    internal class Program
    {
        private static int[] numbers;
        private static bool[] used;
        private static int answer;

        private static void Main()
        {
            var parameters = Console.ReadLine().Split(' ');
            var n = int.Parse(parameters[0]);
            int k = int.Parse(parameters[1]);
            numbers = new int[k];
            used = new bool[n];

            Reqursive(0, n);
            Console.WriteLine(answer);
        }

        private static void Reqursive(int start, int end)
        {
            if (start == numbers.Length)
            {
                //Console.WriteLine(string.Join(",", numbers));
                var setFound = true;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] <= numbers[i + 1] && i % 2 == 0)
                    {
                        setFound = false;
                        break;
                    }

                    if (numbers[i] >= numbers[i + 1] && i % 2 == 1)
                    {
                        setFound = false;
                        break;
                    }

                }

                if (setFound)
                {
                    answer++;
                }

                return;
            }

            for (int i = 0; i < end; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    numbers[start] = i;
                    Reqursive(start + 1, end);
                    used[i] = false;
                }
            }
        }
    }
}
