using System;
using System.Threading;
using System.Globalization;


class BiggestOfThreeInt
{
    static void Main()
    {
        /*
        Problem 5. The Biggest of 3 Numbers
            Write a program that finds the biggest of three numbers.
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

        if (str.IndexOf(",", 0) > -1)
        {
            number1 /= (float) Math.Pow(10, str.Length - 2);
        }

        Console.Write(" Insert the second int: ");
        string str1 = Console.ReadLine();
        float number2;

        while (!(float.TryParse(str1, out number2)))
        {
            Console.Write(" Insert the second int: ");
            str1 = Console.ReadLine();
        }

        if (str1.IndexOf(",", 0) > -1)
        {
            number2 /= (float)Math.Pow(10, str1.Length - 2); ;
        }

        Console.Write(" Insert the third int: ");
        string str2 = Console.ReadLine();
        float number3;

        while (!(float.TryParse(str2, out number3)))
        {
            Console.Write(" Insert the third int: ");
            str2 = Console.ReadLine();
        }

        if (str2.IndexOf(",", 0) > -1)
        {
            number3 /= (float)Math.Pow(10, str2.Length - 2); ;
        }

        if((number1 > number2) && (number1 > number3))
        {
            Console.WriteLine(" The biggest number is {0}! \n", number1);
        }
        else
        {
            if ((number2 > number1) && (number2 > number3))
            {
                Console.WriteLine(" The biggest number is {0}! \n", number2);
            }
            else
            {
                if ((number3 > number1) && (number3 > number2))
                {
                    Console.WriteLine(" The biggest number is {0}! \n", number3);
                }
            }
        }
    }
}
