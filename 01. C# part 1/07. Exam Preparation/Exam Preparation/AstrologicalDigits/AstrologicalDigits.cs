using System;

class AstrologicalDigits
{
    static void Main()
    {
        string number = Console.ReadLine();

        int result = 0;

        while (true)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    int digit = number[i] - 48;
                    result += digit;
                }
            }

            if (result < 10)
            {
                break;
            }

            number = result.ToString();
            result = 0;
        }

        Console.WriteLine(result);
    }
}