using System;
using System.Collections.Generic;
using System.Text;

class SubtractPolyn
{
    static void Main()
    {
        /*
         Problem 12. Subtracting polynomials
            Extend the previous program to support also subtraction and multiplication of polynomials.
         */
        int[] polinominal1 = new int[] { 5, 0, -1 };
        int[] polinominal2 = new int[] { 1, 4, 6, 5 };

        Console.Write("Polinominal1: ");
        PrintPolinominals(polinominal1);
        Console.WriteLine();

        Console.Write("Polinominal2: ");
        PrintPolinominals(polinominal2);
        Console.WriteLine();

        int[] multiplyResult = MultiplyPol(polinominal1, polinominal2);
       
        List<int> result = SubtractPol(polinominal1, polinominal2);
        Console.Write("Result of subtract two pols: ");
        PrintPolinominalsSubstract(result.ToArray());
        Console.WriteLine();

        Console.Write("Result of multiply two pols: ");
        PrintPolinominalsSubstract(multiplyResult);
        Console.WriteLine();
    }

    static void PrintPolinominalsSubstract(int[] pol1)
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
                    }
                }
            }
        }
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

    static List<int> SubtractPol(int[] pol1, int[] pol2)
    {
        List<int> result = new List<int>();

        if (pol1.Length < pol2.Length)
        {
            for (int i = 0; i < pol2.Length; i++)
            {
                if (i < pol1.Length)
                {
                    result.Add(pol1[i] - pol2[i]);
                }
                else
                {
                    pol2[i] *= -1;
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
                    result.Add(pol1[i] - pol2[i]);
                }
                else
                {
                    pol1[i] *= -1;
                    result.Add(pol1[i]);
                }
            }
        }

        return result;
    }

    static int[] MultiplyPol(int[] pol1, int[] pol2)
    {
        int[] result = new int[pol1.Length * pol2.Length];


        for (int i = 0; i < pol1.Length; i++)
        {
            for (int j = 0; j < pol2.Length; j++)
            {
                result[i + j] += pol1[i] * pol2[j];
            }
        }

        return result;
    }
}