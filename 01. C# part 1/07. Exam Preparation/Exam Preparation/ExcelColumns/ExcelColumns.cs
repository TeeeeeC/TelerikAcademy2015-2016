using System;

class ExcelColumns
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        long result = 0;

        for (int i = 1; i <= rows; i++)
        {
            string  str = Console.ReadLine();
            char upperLetter = str[0];

            int multiply = (int)(upperLetter - 64);

            result += (long)Math.Pow(26, rows - i) * multiply;
        }

        Console.WriteLine(result);
    }
}
