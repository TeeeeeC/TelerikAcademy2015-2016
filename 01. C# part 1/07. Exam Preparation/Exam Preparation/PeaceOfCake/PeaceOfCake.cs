using System;
using System.Threading;
using System.Globalization;

class PeaceOfCake
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());

        decimal firstResult = ((a / b) + (c / d));
        int firstResultCheck = 0;

        if(firstResult > 1)
        {
            firstResultCheck = (int)firstResult;
            Console.WriteLine(firstResultCheck);
        }
        else
        {
            Console.WriteLine("{0:F22}", firstResult);
        }

        decimal secondResult = (a * d) + (b * c);
        decimal thirdResult = (b * d);

        Console.WriteLine("{0}/{1}", secondResult, thirdResult);
    }
}
