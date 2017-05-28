using System;

class LastDigitToEngWordMethod
{
    static void Main()
    {
        /*
         Problem 3. English digit
            Write a method that returns the last digit of given integer as an English word.
         */
        Console.Write("Enter number: ");
        string num = Console.ReadLine();
        ReturnLastDigToEngWord(num);
    }

    static void ReturnLastDigToEngWord(string number)
    {
        char ch = number[number.Length - 1];
        string word = string.Empty;

        switch(ch)
        {
            case '0': word = "Zero"; break;
            case '1': word = "One"; break;
            case '2': word = "Two"; break;
            case '3': word = "Three"; break;
            case '4': word = "Four"; break;
            case '5': word = "Five"; break;
            case '6': word = "Six"; break;
            case '7': word = "Seven"; break;
            case '8': word = "Eight"; break;
            case '9': word = "Nine"; break;
        }
        Console.WriteLine("{0}->{1}", number, word);
    }
}
