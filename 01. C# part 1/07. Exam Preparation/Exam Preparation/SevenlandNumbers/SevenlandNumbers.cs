using System;

class SevenlandNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string number = num.ToString();

        if (number.Length == 1 && num == 6)
        {
            Console.WriteLine(num + 4);
        }
        else if (number.Length == 2)
        {
            if (num == 66)
            {
                Console.WriteLine(num + 34);
            }
            else if (num % 10 == 6)
            {
                Console.WriteLine(num + 4);
            }
            else
            {
                Console.WriteLine(num + 1);
            }
        }
        else if (number.Length == 3)
        {
            if (num == 666)
            {
                Console.WriteLine(num + 334);
            }
            else if (num % 100 == 66)
            {
                Console.WriteLine(num + 34);
            }
            else if (num % 10 == 6)
            {
                Console.WriteLine(num + 4);
            }
            else
            {
                Console.WriteLine(num + 1);
            }
        }
        else
        {
            Console.WriteLine(num + 1);
        }
    }
}
