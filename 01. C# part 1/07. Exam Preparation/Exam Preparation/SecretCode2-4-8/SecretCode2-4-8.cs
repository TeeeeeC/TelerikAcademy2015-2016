using System;

class SecretCode2_4_8
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long result = 0;
        long remainder = 0;

        if (b == 2)
        {
            result = a % c;
            remainder += result % 4;

            if (remainder == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(remainder);
                Console.WriteLine(result);
            }
        }
        else if (b == 4)
        {
            result = a + c;
            remainder += result % 4;

            if (remainder == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(remainder);
                Console.WriteLine(result);
            }
        }
        else if (b == 8)
        {
            result = a * c;
            remainder += result % 4;

            if (remainder == 0)
            {
                Console.WriteLine(result / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(remainder);
                Console.WriteLine(result);
            }
        }
    }
}