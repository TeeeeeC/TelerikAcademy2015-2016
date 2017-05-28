using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        /*
         Problem 16. Date difference
            Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
            27.02.2006
            3.03.2006
         */
        IFormatProvider culture = new CultureInfo("de-DE", true);

        Console.Write("Enter the first date 'DD.MM.YYYY': ");
        string firstDate = Console.ReadLine();
        DateTime date1 = DateTime.Parse(firstDate, culture);

        Console.Write("Enter the second date'DD.MM.YYYY': ");
        string secondDate = Console.ReadLine();
        DateTime date2 = DateTime.Parse(secondDate, culture);

        if (date2 > date1)
        {
            Console.WriteLine("Distance: {0} days", (date2 - date1).Days);
        }
        else
        {
            Console.WriteLine("Distance: {0} days", (date1 - date2).Days);
        }
    }
}
