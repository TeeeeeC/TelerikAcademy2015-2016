using System;
using System.Text;
using System.Collections.Generic;

class SumTwoPol
{
    static void Main()
    {
        /*
         Problem 11. Adding polynomials
            Write a method that adds two polynomials.
            Represent them as arrays of their coefficients.
         */
        int[] polinominal1 = new int[] { 5, 0, -1};
        int[] polinominal2 = new int[] { 1, 4, 6, 5 };
        List<int> result = AddPol(polinominal1, polinominal2);

        Console.Write("Polinominal1: ");
        PrintPolinominals(polinominal1);
        Console.WriteLine();

        Console.Write("Polinominal2: ");
        PrintPolinominals(polinominal2);
        Console.WriteLine();

        Console.Write("Result of add two pols: ");
        PrintPolinominals(result.ToArray());
        Console.WriteLine();
    }

    static void PrintPolinominals(int[] pol1)
    {
        for (int i = pol1.Length - 1; i >= 0; i--)
        {
            if (pol1.Length == 0)
            {
                Console.Write("0");
            }
            else if (pol1.Length == 1)
            {
                Console.Write("{0}", pol1[i]);
            }
            else
            {
                if (pol1[i] != 0)
                {
                    if (i > 0)
                    {
                        Console.Write("{0}x^{1}", pol1[i], i);
                    }
                    else
                    {
                        Console.Write("{0}", pol1[i]);
                    }

                    if (i - 1 >= 0)
                    {
                        if (pol1[i - 1] >= 0)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                }
            }
        }
    }

    static List<int> AddPol(int[] pol1, int[] pol2)
    {
        List<int> result = new List<int>();

        if (pol1.Length < pol2.Length)
        {
            for (int i = 0; i < pol2.Length; i++)
            {
                if (i < pol1.Length)
                {
                    result.Add(pol1[i] + pol2[i]);
                }
                else
                {
                    result.Add(pol2[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < pol1.Length; i++)
            {
                if (i < pol2.Length)
                {
                    result.Add(pol1[i] + pol2[i]);
                }
                else
                {
                    result.Add(pol1[i]);
                }
            }
        }

        return result;
    }
}
