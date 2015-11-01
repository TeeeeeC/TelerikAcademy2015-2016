using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        /*
         Problem 17.* Calculate GCD
            Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
            Use the Euclidean algorithm (find it in Internet).
         */
        string strN = "", strX = "";
        int numberN = 0, numberX = 0;

        Console.WriteLine(" Greatest Common Divisor\n");

        do
        {
            Console.Write(" Insert number N: ");
            strN = Console.ReadLine();
            int.TryParse(strN, out numberN);
            Console.Write(" Insert number X: ");
            strX = Console.ReadLine();
            int.TryParse(strX, out numberX);

        } while ((!(int.TryParse(strN, out numberN))) || (numberN < 0) || (!(int.TryParse(strX, out numberX))) || (numberN < 0));

        int maxNumber = Math.Max(numberN, numberX);
        int minNumber = Math.Min(numberN, numberX);
        int result = 0, remaider = 0;

        result = maxNumber / minNumber;
        remaider = maxNumber % minNumber;

        while(remaider != 0)
        {
            maxNumber = minNumber;
            minNumber = remaider;
            result = maxNumber / minNumber;
            remaider = maxNumber % minNumber;
        }

        Console.WriteLine(" gcd(N, X) = {0}\n", minNumber);
    }
}

