using System;
using System.Threading;
using System.Globalization;

class ExamineTwoInt
{
    static void Main()
    {
        /*
         Problem 1. Exchange If Greater
            Write an if-statement that takes two double variables a and b and exchanges their values 
            if the first one is greater than the second one. As a result print the values a and b, 
            separated by a space.
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write(" Insert the first int: ");
        string str = Console.ReadLine();
        double number1;

        while (!(double.TryParse(str, out number1)))
        {
            Console.Write(" Insert the first int: ");
            str = Console.ReadLine();
        }

        if (str.IndexOf(",", 0) > -1)
        {
            number1 /= Math.Pow(10, str.Length - 2);
        }

        Console.Write(" Insert the second int: ");
        string str1 = Console.ReadLine();
        double number2;

        while (!(double.TryParse(str1, out number2)))
        {
            Console.Write(" Insert the second int: ");
            str1 = Console.ReadLine();
        }

        if (str1.IndexOf(",", 0) > -1)
        {
            number2 /= Math.Pow(10, str1.Length - 2);
        }

        if (number1 > number2)
        {
            double swap;
            swap = number1;
            number1 = number2;
            number2 = swap;

            Console.WriteLine(" {0} {1}", number1, number2);
        }
        else
        {
            if (number1 == number2)
            {
                Console.WriteLine(" {0} {1}", number2, number2);
            }
            else
            {
                Console.WriteLine(" {0} {1}", number1, number2);
            }
        }
    }
}

