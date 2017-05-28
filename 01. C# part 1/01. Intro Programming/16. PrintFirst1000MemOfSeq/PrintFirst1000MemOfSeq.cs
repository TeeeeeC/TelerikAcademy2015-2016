using System;

class PrintFirst1000MemOfSeq
{
    static void Main()
    {
        /*
         Problem 16.* Print Long Sequence
            Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
            You might need to learn how to use loops in C# (search in Internet).
         */

        int result = 0;

        for (int i = 2; i < 1002; i++)
        {
            result = i;

            if (i %2 == 1)
            {
                result *= -1;
            }

            Console.Write("{0}, ", result);
        }
    }
}
