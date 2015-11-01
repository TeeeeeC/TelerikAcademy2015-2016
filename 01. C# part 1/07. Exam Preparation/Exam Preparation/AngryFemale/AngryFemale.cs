using System;

class AngryFemale
{
    static void Main()
    {
        string num = Console.ReadLine();
        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == '-')
            {
                continue;
            }

            int digit = num[i] - '0';

            if (digit % 2 == 0)
            {
                evenSum += digit;
            }
            else
            {
                oddSum += digit;
            }
        }

        if (evenSum > oddSum)
        {
            Console.WriteLine("right {0}", evenSum);
        }
        else if (evenSum < oddSum)
        {
            Console.WriteLine("left {0}", oddSum);
        }
        else
        {
            Console.WriteLine("straight {0}", oddSum);
        }
    }
}
