using System;
using System.Globalization;

class ExtractDates
{
    static void Main()
    {
        /*
         Problem 19. Dates from text in Canada
            Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
            Display them in the standard date format for Canada.
         */
        IFormatProvider culture = new CultureInfo("en-CA", true);
        string text = "fgfdgdgd 29.03.2014 29.02.2013 gd dfdg fggggggd 30.04.2013 g g 2.3 33.2.333";

        for (int i = 0; i < text.Length - 9; i++)
        {
            if(char.IsDigit(text[i]))
            {
                for(int j = 0; j <= 1; j++)
                {
                    string strDate = text.Substring(i, 9 + j);
                    DateTime date; 
                    
                    if(DateTime.TryParseExact(strDate, "dd.MM.yyyy", culture, DateTimeStyles.None, out date))
                    {
                        DateTime dt = date;
                        Console.WriteLine("{0}.{1}.{2}", date.Day, date.Month, date.Year);
                        i += 9;
                    }
                }
            }
        }
    }
}
