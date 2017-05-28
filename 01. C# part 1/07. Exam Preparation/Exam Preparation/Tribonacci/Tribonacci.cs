using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        int firstNumInt = int.Parse(Console.ReadLine());
        int secondNumInt = int.Parse(Console.ReadLine());
        int thirdNumInt = int.Parse(Console.ReadLine());
        int numberN = int.Parse(Console.ReadLine());

        BigInteger result = 0, firstNum = firstNumInt, secondNum = secondNumInt, thirdNum = thirdNumInt;

        if (numberN > 3)
        {
            for (int i = 3; i < numberN; i++)
            {
                result = firstNum + secondNum + thirdNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = result;
            }

            Console.WriteLine(result);
        }
        else
        {
            switch(numberN)
            {
                case 1: Console.WriteLine(firstNum); break;
                case 2: Console.WriteLine(secondNum); break;
                case 3: Console.WriteLine(thirdNum); break;
                default: break;
            }
        }
    }
}
