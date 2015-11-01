using System;
class ReverseDecNum
{
    static void Main()
    {
        /*
         Problem 7. Reverse number
            Write a method that reverses the digits of given decimal number.
         */
        Console.Write("Insert decimal number: ");
        string number = Console.ReadLine();

        ReverseNum(number);
    }

    static void ReverseNum(string num)
    {
        Console.Write(num + "->");

        for (int i = num.Length - 1; i >= 0; i--)
        {
            Console.Write(num[i]);
        }
        Console.WriteLine();
    }
}
