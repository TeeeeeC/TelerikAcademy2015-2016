using System;

class PrintRandValues
{
    static void Main()
    {
        /*
         Problem 2. Random numbers
            Write a program that generates and prints to the console 10 random values in the range [100, 200].
         */
        Random rand = new Random();

        int counter = 0;

        while(counter != 10)
        {
            int number = rand.Next(201);

            if (number > 99)
            {
                Console.Write("{0}, ", number);
                counter++;
            }
        }

        Console.WriteLine();
    }
}
