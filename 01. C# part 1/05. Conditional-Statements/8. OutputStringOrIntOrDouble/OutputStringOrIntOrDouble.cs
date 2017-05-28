using System;
using System.Threading;
using System.Globalization;

class OutputStringOrIntOrDouble
{
    static void Main()
    {
        /*
         Problem 9. Play with Int, Double and String
            Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            If the variable is int or double, the program increases it by one.
            If the variable is a string, the program appends * at the end.
            Print the result at the console. Use switch statement.
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine(" User's choice input \n");
        string number = "";

        do
        {
            Console.Write(" Insert number (0 -> int , 1 -> double, 2 -> string: ");
            number = Console.ReadLine();

        } while ((number != "0") && (number != "1") && (number != "2"));

        int digit = int.Parse(number);
        string numberInt = "", numberDouble = "", str = "";
        int resultInt;
        double resultDouble;
        
        switch (digit)
        {
            case 0: do
                    {
                        Console.Write(" Insert int number: ");
                        numberInt = Console.ReadLine();

                    }while (!(int.TryParse(numberInt, out resultInt)));

                    Console.WriteLine(" The result is {0}", resultInt + 1); break;

            case 1: do
                    {
                        Console.Write(" Insert double number: ");
                        numberDouble = Console.ReadLine();

                    } while (!(double.TryParse(numberDouble, out resultDouble)));

                    Console.WriteLine(" The result is {0}", resultDouble + 1); break;

            case 2: 
                    Console.Write(" Insert string: ");
                    str = Console.ReadLine();
                    Console.WriteLine(" The result is: {0}", str + "*"); break; 

            default: Console.WriteLine(" Error! \n"); break;
        }

    }
}

