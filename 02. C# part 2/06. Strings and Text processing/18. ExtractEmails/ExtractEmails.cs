using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        /*
         Problem 18. Extract e-mails
            Write a program for extracting all email addresses from given text.
            All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
         */

        string text = "ivan@hodi.com, gosho@pishe.net, 232--@bg.net, best.best2@bg.some-host.2323.com, "
                    + ".drun.@dan.com, best@-host.com, user@.best.bg, test@user.bg., drunbrun@, gosho@host, @bg.net, test#mail.com";
        string pattern = @"\b([a-zA-Z0-9_\-][a-zA-Z0-9_\-]{0,49})@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})\b(?=,|\s)";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine(text);
        Console.WriteLine();

        foreach(Match match in matches)
        {
            Console.WriteLine("Valid email: {0}", match.Value);
        }
    }
}
