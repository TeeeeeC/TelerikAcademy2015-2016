using System;
using System.Threading;
using System.Globalization;

class SortThreeIntInDescendingOrder
{
    static void Main()
    {
        /*
        Problem 7. Sort 3 Numbers with Nested Ifs
            Write a program that enters 3 real numbers and prints them sorted in descending order.
            Use nested if statements.
            Note: Don’t use arrays and the built-in sorting functionality.
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write(" Insert the first num: ");
        string str = Console.ReadLine();
        float number1;

        while (!(float.TryParse(str, out number1)))
        {
            Console.Write(" Insert the first num: ");
            str = Console.ReadLine();
        }

        Console.Write(" Insert the second num: ");
        string str1 = Console.ReadLine();
        float number2;

        while (!(float.TryParse(str1, out number2)))
        {
            Console.Write(" Insert the second num: ");
            str1 = Console.ReadLine();
        }

        Console.Write(" Insert the third num: ");
        string str2 = Console.ReadLine();
        float number3;

        while (!(float.TryParse(str2, out number3)))
        {
            Console.Write(" Insert the third num: ");
            str2 = Console.ReadLine();
        }

        if (str.IndexOf(",", 0) > -1)
        {
            number1 /= (float)Math.Pow(10, str.Length - 2);
        }
        if (str1.IndexOf(",", 0) > -1)
        {
            number2 /= (float)Math.Pow(10, str1.Length - 2);
        }
        if (str2.IndexOf(",", 0) > -1)
        {
            number3 /= (float)Math.Pow(10, str2.Length - 2);
        }

        if ((number1 > number2) && (number1 > number3))
        {
            if (number2 > number3)
            {
                Console.WriteLine(" {0} {1} {2}", number1, number2, number3);
            }
            else
            {
                Console.WriteLine(" {0} {1} {2}", number1, number3, number2);
            }
        }
        else
        {
            if ((number2 > number1) && (number2 > number3))
            {
                if (number1 > number3)
                {
                    Console.WriteLine(" {0} {1} {2}", number2, number1, number3);
                }
                else
                {
                    Console.WriteLine(" {0} {1} {2}", number2, number3, number1);
                }
            }
            else
            {
                if ((number3 > number1) && (number3 > number2))
                {
                    if (number1 > number2)
                    {
                        Console.WriteLine(" {0} {1} {2}", number3, number1, number2);
                    }
                    else
                    {
                        Console.WriteLine(" {0} {1} {2}", number3, number2, number1);
                    }
                }
            }
        }
    }
}

