namespace Passwords
{
    using System;
    using System.Numerics;

    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var asterixesCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    asterixesCount++;
                }
            }

            BigInteger result = 1;
            for (int i = 0; i < asterixesCount; i++)
            {
                result *= 2;
            }
            Console.WriteLine(result);
        }
    }
}
