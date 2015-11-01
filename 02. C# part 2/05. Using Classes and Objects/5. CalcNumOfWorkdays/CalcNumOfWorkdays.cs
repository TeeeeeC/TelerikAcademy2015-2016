using System;

class CalcNumOfWorkdays
{
    public static string[] arr = { "1.1.2015", "3.3.2015" };

    public static string saturday = "Saturday";
    public static string sunday = "Sunday";

    static void Main()
    {
        /*
         Problem 5. Workdays
            Write a method that calculates the number of workdays between today and given date, passed as parameter.
            Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
         */
        CalculateWorkDays(2015, 1, 1);
    }

    public static void CalculateWorkDays(int year, int month, int day)
    {
        DateTime passedDate = new DateTime(year, month, day);

        object startDate = passedDate.Day + "." + passedDate.Month + "." + passedDate.Year;
        int countWorkDays = 0;

        while(passedDate != DateTime.Today.AddDays(1))
        {
            object dayOfWeek = passedDate.DayOfWeek;
            object currentDate = passedDate.Day + "." + passedDate.Month + "." + passedDate.Year;
            bool weekends = true;
            bool holidays = true;

            if (saturday == dayOfWeek.ToString() || sunday == dayOfWeek.ToString())
            {
                weekends = false;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                if (currentDate.ToString() == arr[i])
                {
                    holidays = false;    
                    break;
                }
            }

            if (weekends && holidays)
            {
                countWorkDays++;
            }

            passedDate = passedDate.AddDays(1);
        }

        Console.WriteLine("Workdays from date {0} to date {1} are {2}!", startDate, DateTime.Today, countWorkDays);
    }
}
