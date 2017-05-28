using System;

class TripleRotationOfDigit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int result = 0, remainder = 0;
        string finalResult = string.Empty;

        if (num > 999)
        {
            result += num / 1000;
            remainder += num % 1000;

            if (remainder > 0)
            {
                finalResult = remainder.ToString() + result.ToString();
            }
            else
            {
                finalResult = result.ToString();
            }

            Console.WriteLine(finalResult);
        }
        else if (num > 99)
        {
            finalResult = Convert.ToString(num, 10);
            Console.WriteLine(finalResult);
        }
        else if (num > 9)
        {
            finalResult = Convert.ToString(num , 10);
            char digit = finalResult[1];

            if (digit != '0')
            {
                Console.WriteLine("{0}{1}", finalResult[1], finalResult[0]);
            }
            else
            {
                Console.WriteLine("{0}", finalResult[0]);
            }
        }
        else
        {
            Console.WriteLine(num);
        }
    }
}
