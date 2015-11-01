using System;

class CalculateCatalanNumbers
{
    static void Main()
    {
        /*
         Problem 8. Catalan Numbers
            In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
            Write a program to calculate the nth Catalan number by given n (1 < n < 100).
         */
        string strN = "";
        int numberN = 0;

        Console.WriteLine(" Catalan Number\n");

        do
        {
            Console.Write(" Insert number N: ");
            strN = Console.ReadLine();
            int.TryParse(strN, out numberN);

        } while ((!(int.TryParse(strN, out numberN))) || (numberN < 0));

        float result = 1;

        for (float i = numberN + 2, j = 2; ((i <= 2 * numberN) || (j <= numberN)) ; i++, j++)
        {
            result = result * (i / j);
        }
        Console.WriteLine();
        Console.WriteLine(" The catalan number is C{0} = {1}!\n", numberN, result);
    }
}

