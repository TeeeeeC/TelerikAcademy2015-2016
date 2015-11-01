using System;
using System.Collections.Generic;

class AddTwoIntInArr
{
    static void Main()
    {
        /*
         Problem 8. Number as array
            Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
            the last digit is kept in arr[0]).
            Each of the numbers that will be added could have up to 10 000 digits.
         */
        List<char> list = new List<char>();
        Console.Write("Insert number1: ");
        string number1 = Console.ReadLine();
        Console.Write("Insert number2: ");
        string number2 = Console.ReadLine();

        AddIntInArr(list, number1, number2);
    }

    static void AddIntInArr(List<char> list, string str1, string str2)
    {
        for (int i = str1.Length - 1; i >= 0;  i--)
        {
            list.Add(str1[i]);
        }

        for (int i = str2.Length - 1; i >= 0; i--)
        {
            list.Add(str2[i]);
        }

        foreach (char element in list)
        {
            Console.Write("{0}, ", element);
        }
        Console.WriteLine();
    }
}
