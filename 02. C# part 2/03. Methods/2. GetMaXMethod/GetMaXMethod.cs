using System;

class GetMaXMethod
{
    static void Main()
    {
        /*
         Problem 2. Get largest number
            Write a method GetMax() with two parameters that returns the larger of two integers.
            Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
         */
        int number1 = 0, number2 = 0, number3 = 0;

        Console.Write("Enter number 1: ");
        string text = Console.ReadLine();
        int.TryParse(text, out number1);

        Console.Write("Enter number 2: ");
        text = Console.ReadLine();
        int.TryParse(text, out number2);

        Console.Write("Enter number 3: ");
        text = Console.ReadLine();
        int.TryParse(text, out number3);

        int max = GetMax(number1, number2);
        max = GetMax(max, number3);
        Console.WriteLine(max);
    }

    static int GetMax(int num1, int num2)
    {
        if (num1 > num2)
            return num1;
        else
            return num2;
    }
}
