namespace ColorBalls
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            var colors = new Dictionary<char, int>();
            var line = Console.ReadLine();
            foreach (var letter in line)
            {
                if (!colors.ContainsKey(letter))
                {
                    colors.Add(letter, 1);
                }
                else
                {
                    colors[letter] += 1;
                }
            }

            var answer = Factoriel(line.Length);
            foreach (var color in colors)
            {
                answer /= Factoriel(color.Value);
            }

            Console.WriteLine(answer);
        }

        private static BigInteger Factoriel(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * Factoriel(number - 1);
        }
    }
}
