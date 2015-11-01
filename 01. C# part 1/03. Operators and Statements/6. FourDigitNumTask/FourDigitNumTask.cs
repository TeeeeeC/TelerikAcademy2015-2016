using System;
using System.Text;

class FourDigitNumTask
{
    static void Main()
    {
        /*
         Problem 6. Four-Digit Number
            Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
                Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
                Prints on the console the number in reversed order: dcba (in our example 1102).
                Puts the last digit in the first position: dabc (in our example 1201).
                Exchanges the second and the third digits: acbd (in our example 2101).
T           he number has always exactly 4 digits and cannot start with 0.
         */
        string str = string.Empty;
        int num = 0;

        do
        {
            Console.Write("Number: ");
            str = Console.ReadLine();
            int.TryParse(str, out num);

        } while((num < 1000) || (num > 9999));

        int sumOfDigits = 0;

        for (int i = 0; i < 4; i++)
        {
            int digit = (int)str[i] - 48;
            sumOfDigits += digit;
        }

        StringBuilder reversed = new StringBuilder();

        for (int j = 3; j >= 0; j--)
        {
            char ch = str[j];
            reversed.Append(ch);
        }

        char firstDigit = str[0];
        char lastDigit = str[3];
        char swap = firstDigit;
        firstDigit = lastDigit;
        lastDigit = swap;

        char secondDigit = str[1];
        char thirdDigit = str[2];
        char temp = secondDigit;
        secondDigit = thirdDigit;
        thirdDigit = temp;

        Console.WriteLine("Sum of digits: {0}", sumOfDigits);
        Console.WriteLine("Reversed digits: {0}", reversed);
        Console.WriteLine("Last digit in fornt: {0}{1}{2}{3}", firstDigit, str[1], str[2], lastDigit);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", str[0], secondDigit, thirdDigit, str[3]);
    }
}
