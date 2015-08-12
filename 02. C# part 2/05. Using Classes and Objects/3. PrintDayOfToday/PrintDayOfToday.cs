using System;

class PrintDayOfToday
{
    static void Main()
    {
        /*
         Problem 3. Day of week
            Write a program that prints to the console which day of the week is today.
            Use System.DateTime.
         */
        DateTime today = new DateTime();
        today = DateTime.Now;
        Console.WriteLine(today.DayOfWeek);

    }
}
