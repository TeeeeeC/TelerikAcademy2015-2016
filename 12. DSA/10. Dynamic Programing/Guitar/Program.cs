namespace Guitar
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            var numbersCount = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var startNumber = int.Parse(Console.ReadLine());
            var min = 0;
            var max = int.Parse(Console.ReadLine());

            var d = new int[numbersCount + 1, max + 1];
            d[0, startNumber] = 1;

            for (int i = 1; i <= numbersCount; i++)
            {
                for (int j = 0; j <= max; j++)
                {
                    if (d[i - 1, j] == 1)
                    {
                        if (j - numbers[i - 1] >= min)
                        {
                            d[i, j - numbers[i - 1]] = 1;
                        }

                        if (j + numbers[i - 1] <= max)
                        {
                            d[i, j + numbers[i - 1]] = 1;
                        }
                    }
                }
            }

            var answer = 0;
            for (int i = max; i >= 0; i--)
            {
                if (d[numbersCount, i] == 1)
                {
                    answer = i;
                    break;
                }
            }

            if (answer >= 0 && d[numbersCount, answer] == 1)
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
