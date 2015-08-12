using System;
using System.Threading;
using System.Globalization;

class PrintSignOfNumProduct
{
    static void Main()
    {
        /*
         Problem 4. Multiplication Sign
            Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            Use a sequence of if operators.
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write(" Insert the first int: ");
        string str = Console.ReadLine();
        float number1;

        while (!(float.TryParse(str, out number1)))
        {
            Console.Write(" Insert the first int: ");
            str = Console.ReadLine();
        }

        Console.Write(" Insert the second int: ");
        string str1 = Console.ReadLine();
        float number2;

        while (!(float.TryParse(str1, out number2)))
        {
            Console.Write(" Insert the second int: ");
            str1 = Console.ReadLine();
        }

        Console.Write(" Insert the third int: ");
        string str2 = Console.ReadLine();
        float number3;

        while (!(float.TryParse(str2, out number3)))
        {
            Console.Write(" Insert the third int: ");
            str2 = Console.ReadLine();
        }

        if ((number1 < 0) && (number2 < 0) && (number3 < 0))
        {
            Console.WriteLine("-");
        }
        else
        {
            if ((number1 < 0) && (number2 > 0) && (number3 > 0))
            {
                Console.WriteLine("-");
            }
            else
            {
                if ((number1 > 0) && (number2 < 0) && (number3 > 0))
                {
                    Console.WriteLine("-");
                }
                else
                {
                    if ((number1 > 0) && (number2 > 0) && (number3 < 0))
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        if ((number1 == 0) || (number2 == 0) || (number3 == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("+");
                        }
                    }
                }
            }
        }
    }
}

