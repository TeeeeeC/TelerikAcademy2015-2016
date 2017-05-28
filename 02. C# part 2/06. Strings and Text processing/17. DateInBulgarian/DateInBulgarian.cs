using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        /*
         Problem 17. Date in Bulgarian
            Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date 
            and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
         */
        IFormatProvider culture = new CultureInfo("de-DE", true);

        Console.Write("Enter the date 'dd.mm.yyyy hour:minute:second': ");
        string firstDate = Console.ReadLine();
        DateTime date = DateTime.Parse(firstDate, culture);

        date = date.AddHours(6);
        date = date.AddMinutes(30);
        Console.WriteLine("Date after 6 hours and 30 minutes: {0}.{1}.{2} {3}:{4}:{5}", date.Day, date.Month, date.Year, date.Hour, date.Minute, date.Second);
    }
}
