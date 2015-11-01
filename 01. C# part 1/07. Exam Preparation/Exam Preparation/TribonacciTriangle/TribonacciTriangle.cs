using System;

class TribonacciTriangle
{
    static void Main()
    {
        long num1 = long.Parse(Console.ReadLine());
        long num2 = long.Parse(Console.ReadLine());
        long num3 = long.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());

        long result = 0;

        if (rows == 2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2 + " " + num3);
        }
        else
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2 + " " + num3);

            for (int i = 3; i <= rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result = num1 + num2 + num3;
                    Console.Write("{0} ", result);
                    num1 = num2;
                    num2 = num3;
                    num3 = result;
                }

                Console.WriteLine();
            }
        }
    }
}
