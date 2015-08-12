using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        /*
         Problem 2. Reverse string
            Write a program that reads a string, reverses it and prints the result at the console.
         */
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }

        Console.WriteLine("Reversed string: {0}", sb);
    }
}
