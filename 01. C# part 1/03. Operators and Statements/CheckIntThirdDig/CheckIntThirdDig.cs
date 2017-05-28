using System;

class CheckIntThirdDig
{
    static void Main()
    {
        /*
         Problem 5. Third Digit is 7?
            Write an expression that checks for given integer if its third digit from right-to-left is 7.
         */
        Console.Write("Insert number: ");
        int number = int.Parse(Console.ReadLine());
        int a = number / 100;
        int b = a % 10;

        bool remainder = (b == 7);

        Console.WriteLine(remainder);

    }
}