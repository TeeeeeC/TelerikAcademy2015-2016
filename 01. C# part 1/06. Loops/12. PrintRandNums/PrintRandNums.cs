using System;

class PrintRandNums
{
    static void Main()
    {
        /*
         Problem 12.* Randomize the Numbers 1…N
            Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
         */
        Console.Write("Number: ");
        int num = int.Parse(Console.ReadLine());

        Random rand = new Random();

        for (int i = 0; i < num; )
        {
            int result = rand.Next(num + 1);

            if (result > 0 )
            {
                Console.Write("{0} ", result);
                i++;
            }
        }

        Console.WriteLine();
    }
}
