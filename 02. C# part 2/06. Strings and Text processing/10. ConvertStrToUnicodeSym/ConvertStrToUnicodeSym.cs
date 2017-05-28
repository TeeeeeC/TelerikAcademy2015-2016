using System;

class ConvertStrToUnicodeSym
{
    static void Main()
    {
        /*
         Problem 10. Unicode characters
            Write a program that converts a string to a sequence of C# Unicode character literals.
            Use format strings.
         */
        Console.Write("Inser string: ");
        string str = Console.ReadLine();

        
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            Console.Write("\\u{0:x4}", Convert.ToInt32(ch));
        }

        Console.WriteLine();
    }
}
