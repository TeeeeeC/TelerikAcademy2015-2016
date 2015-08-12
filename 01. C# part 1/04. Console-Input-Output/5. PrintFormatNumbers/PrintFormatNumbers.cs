using System;

class PrintFormatNumbers
{
    static void Main()
    {
        /*
         Problem 5. Formatting Numbers
            Write a program that reads 3 numbers:
            integer a (0 <= a <= 500)
            floating-point b
            floating-point c
            The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            The number a should be printed in hexadecimal, left aligned
            Then the number a should be printed in binary form, padded with zeroes
            The number b should be printed with 2 digits after the decimal point, right aligned
            The number c should be printed with 3 digits after the decimal point, left aligned.
         */

        int a = 0;
        string num = string.Empty;

        do
        {
            Console.Write("Insert a [0 <= a <=500]: ");
            num = Console.ReadLine();
            int.TryParse(num, out a);

        } while ((a < 0 || a > 500) || (!int.TryParse(num, out a)));

        Console.Write("Insert b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Insert c: ");
        float c = float.Parse(Console.ReadLine());

        if (c < 100)
        {
            Console.WriteLine("{0:X} |{1}| {2:0.00}|{3:0.000} |", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
        else
        {
            Console.WriteLine("{0:X} |{1}| {2:0.00}|{3:0} |", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
