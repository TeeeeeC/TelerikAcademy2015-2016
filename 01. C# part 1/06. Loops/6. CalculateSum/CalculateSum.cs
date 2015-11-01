using System;

class CalculateSum
{
    static void Main()
    {
        /*
         Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
            Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
            Use only one loop. Print the result with 5 digits after the decimal point.
         */
        string strX = "", strN = "";
        int numberX = 0, numberN = 0;

        Console.WriteLine(" Calculate sum: S = 1 + 1!/X + 2!/(X^2) + ... + N!/(X^N)\n");

        do
        {
            Console.Write(" Insert number N: ");
            strN = Console.ReadLine();
            Console.Write(" Insert number X: ");
            strX = Console.ReadLine();

        } while ((!(int.TryParse(strX, out numberX))) ||(!(int.TryParse(strN, out numberN))));

        double sum = 1, factorial = 1; 
        double power = 1;

        for (int i = 1; i <= numberN ; i++)
        {
            factorial *= i;
            power = Math.Pow(numberX, i);
            sum += (factorial / power);
        }

        Console.WriteLine(" The sum is {0:F5}!", sum);
    }
}

