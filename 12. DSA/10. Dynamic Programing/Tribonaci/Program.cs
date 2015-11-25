using System.Numerics;

namespace Tribonaci
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var parameters = Console.ReadLine().Split(' ');
            BigInteger first = BigInteger.Parse(parameters[0]);
            BigInteger second = BigInteger.Parse(parameters[1]);
            BigInteger third = BigInteger.Parse(parameters[2]);
            int number = int.Parse(parameters[3]);

            BigInteger result = new BigInteger();
            for (int i = 4; i <= number; i++)
            {
                result = first + second + third;
                first = second;
                second = third;
                third = result;
            }

            if (number == 1)
            {
                Console.WriteLine(first); 
            }
            else if (number == 2)
            {
                Console.WriteLine(second);
            }
            else if (number == 3)
            {
                Console.WriteLine(third);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
