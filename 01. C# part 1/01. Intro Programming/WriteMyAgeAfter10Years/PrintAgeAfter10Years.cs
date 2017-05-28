using System;
using System.Globalization;

class PrintAgeAfter10Years
{
    static void Main()
    {
        /*
         Problem 15.* Age after 10 Years
            Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
         */
        Console.Write("Enter your birthday in format (d.M.yyyy): ");
        string birthday = Console.ReadLine();
        DateTime myDate = DateTime.ParseExact(birthday, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime nowDate = DateTime.Now;
        int ageNow = nowDate.Year - myDate.Year;

        if (myDate.Month != nowDate.Month && myDate.Day != nowDate.Day)
        {
            ageNow--;
        }

        Console.WriteLine("My age now is: {0}", ageNow);
        Console.WriteLine("My age after 10 years is: {0}", ageNow + 10);
    }
}
