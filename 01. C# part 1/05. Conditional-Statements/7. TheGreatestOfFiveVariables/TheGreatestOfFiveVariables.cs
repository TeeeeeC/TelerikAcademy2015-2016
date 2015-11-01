using System;
using System.Threading;
using System.Globalization;

class TheGreatestOfFiveVariables
{
    static void Main()
    {
        /*
        Problem 6. The Biggest of Five Numbers
            Write a program that finds the biggest of five numbers by using only five if statements.
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine(" The Greatest of 5 Numbers \n");
        float a = 0, b = 0, c = 0, d = 0, e = 0;
        string number1 = "", number2 = "", number3 = "", number4 = "", number5 = "";

        do
        {
            Console.Write(" Insert number 1: ");
            number1 = Console.ReadLine();
            Console.Write(" Insert number 2: ");
            number2 = Console.ReadLine();
            Console.Write(" Insert number 3: ");
            number3 = Console.ReadLine();
            Console.Write(" Insert number 4: ");
            number4 = Console.ReadLine();
            Console.Write(" Insert number 5: ");
            number5 = Console.ReadLine();


        } while ((!(float.TryParse(number1, out a))) || (!(float.TryParse(number2, out b))) || (!(float.TryParse(number3, out c))) || (!(float.TryParse(number4, out d))) || (!(float.TryParse(number5, out e))));

        //If decimal point is comma
        if (number1.IndexOf(",", 0) > -1)
        {
            a /= (float)Math.Pow(10, number1.Length - 2);
        }
        if (number2.IndexOf(",", 0) > -1)
        {
            b /= (float)Math.Pow(10, number2.Length - 2);
        }
        if (number3.IndexOf(",", 0) > -1)
        {
            c /= (float)Math.Pow(10, number3.Length - 2);
        }
        if (number4.IndexOf(",", 0) > -1)
        {
            d /= (float)Math.Pow(10, number4.Length - 2);
        }
        if (number5.IndexOf(",", 0) > -1)
        {
            e /= (float)Math.Pow(10, number5.Length - 2);
        }

        // Algorithm
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine(" The greatest number of 5 numbers is {0}!\n", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine(" The greatest number of 5 numbers is {0}!\n", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine(" The greatest number of 5 numbers is {0}!\n", c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine(" The greatest number of 5 numbers is {0}!\n", d);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine(" The greatest number of 5 numbers is {0}!\n", e);
        }
        
    }

}

