using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        /*
         Problem 10.* Beer Time
            A beer time is after 1:00 PM and before 3:00 AM.
            Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and 
            AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the 
            time cannot be parsed. Note: You may need to learn how to parse dates and times.
         */
        string input; 
        DateTime date;

        do
        {
        Console.Write("time: ");
        input = Console.ReadLine();

        } while(!DateTime.TryParseExact(input, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out date));

        DateTime startBeerTime = DateTime.ParseExact("1:00 PM", "h:mm tt", CultureInfo.InvariantCulture);
        DateTime endBeerTime = DateTime.ParseExact("3:00 AM", "h:mm tt", CultureInfo.InvariantCulture);

        string str = date.ToString();
        string checkAMorPM = str.Substring(str.Length - 2, 2);
        int hour = startBeerTime.Hour;
        int minite = startBeerTime.Minute;

        if (((date.Hour >= startBeerTime.Hour) && (date.Minute > startBeerTime.Minute) && (checkAMorPM == "PM")) ||
            ((date.Hour < endBeerTime.Hour) && (date.Minute >= endBeerTime.Minute) && (checkAMorPM == "AM")))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
        
    }
}
