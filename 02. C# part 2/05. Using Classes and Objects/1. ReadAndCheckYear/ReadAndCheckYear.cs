using System;

class ReadAndCheckYear
{
    static void Main()
    {
        /*
         Problem 1. Leap year
            Write a program that reads a year from the console and checks whether it is a leap one.
            Use System.DateTime.
         */
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));
    }
}
