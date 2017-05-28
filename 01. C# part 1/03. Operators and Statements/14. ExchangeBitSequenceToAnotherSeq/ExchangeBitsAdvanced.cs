using System;
using System.Text;

class ExchangeBitsAdvanced
{
    static void Main()
    {
        /*
        Problem 16.** Bit Exchange (Advanced)
            Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
            The first and the second sequence of bits may not overlap.
         */
        Console.Write("Enter number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int min = Math.Min(q, k);
        int max = Math.Max(q, k);
        q = min;
        k = max;

        StringBuilder result = new StringBuilder();
        string strNumber = Convert.ToString(n, 2).PadLeft(32, '0');

        try
        {
            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                if (i >= strNumber.Length - q)
                {
                    result.Append(strNumber[i]);
                }
                else
                {
                    i = strNumber.Length - k - 1;

                    for (int j = i; j > i - p; j--)
                    {
                        result.Append(strNumber[j]);
                    }

                    i = strNumber.Length - q - p;

                    while (i != strNumber.Length - k)
                    {
                        i--;
                        result.Append(strNumber[i]);

                    }

                    i = strNumber.Length - q - 1;

                    for (int t = i; t > i - p; t--)
                    {
                        result.Append(strNumber[t]);
                    }

                    i = strNumber.Length - k - p;

                    while (i != 0)
                    {
                        i--;
                        result.Append(strNumber[i]);

                    }
                }
            }

            string resultRev = result.ToString();
            result.Clear();

            for (int f = resultRev.Length - 1; f >= 0; f--)
            {
                result.Append(resultRev[f]);
            }

            Console.WriteLine("Binary result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Result:        {0}", result);
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("First and Second sequence were overlapped!");
        }
    }
}
