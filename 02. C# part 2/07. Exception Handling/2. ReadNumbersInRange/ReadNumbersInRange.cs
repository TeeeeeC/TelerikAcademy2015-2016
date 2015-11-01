using System;

class ReadNumbersInRange
{
    private static bool ReadNumber(int start, int end)
    {
        try
        {
            Console.Write("Insert number in range[{0}-{1}]: ", start, end);
            int num = int.Parse(Console.ReadLine());

            if (num >= start && num <= end)
            {
                Console.WriteLine("Number is {0}!", num);
                return true;
            }
            else
            {
               throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number argument out of range exception!");
            return false;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
            return false;
        }
    }

    static void Main()
    {
        /*
         Problem 2. Enter numbers
            Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
            If an invalid number or non-number text is entered, the method should throw an exception.
            Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
         */
        int i = 0;
        
        while(i != 10)
        {
            bool methodReadNumber = ReadNumber(50, 100);

            if (methodReadNumber)
            {
                i++;
            }
        }
    }
}
