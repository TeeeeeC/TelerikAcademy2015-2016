using System;
using System.Text;
using System.Threading;
using System.Globalization;

class SolveTasks
{
    static void Main()
    {
        /*
         Problem 13. Solve tasks
            Write a program that can solve these tasks:
                Reverses the digits of a number
                Calculates the average of a sequence of integers
                Solves a linear equation a * x + b = 0
            Create appropriate methods.
            Provide a simple text-based menu for the user to choose which task to solve.
            Validate the input data:
                The decimal number should be non-negative
                The sequence should not be empty
                a should not be equal to 0
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("             Menu");
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0");
        Console.WriteLine("4. Quit");
        Console.WriteLine();

        string input = string.Empty;
        int choice = 0;

        do
        {
            Console.Write("Please choose options (1, 2, 3 or 4): ");
            input = Console.ReadLine();
            int.TryParse(input, out choice);

        }while(choice < 1 || choice > 4);

        switch(choice)
        {
            case 1: 
                decimal number = 0;

                do
                {
                    Console.Write("Enter positive decimal number: ");
                    input = Console.ReadLine();
                    decimal.TryParse(input, out number);

                }while (number < 0 || !decimal.TryParse(input, out number));

                string reversedNum = ReversedDecimalNum(number);
                Console.WriteLine("Reversed decimal number: {0}", reversedNum);

                break;
            case 2:
                do
                {
                    Console.Write("Enter sequence of integers: ");
                    input = Console.ReadLine();

                } while (input.Length < 1);

                decimal average = CalculateAverage(input);
                Console.WriteLine("Average result: {0}", average);

                break;
            case 3:
                decimal a = 0, b = 0;

                do
                {
                    Console.Write("Enter coeff a: ");
                    input = Console.ReadLine();
                    decimal.TryParse(input, out a);

                    Console.Write("Enter coeff b: ");
                    input = Console.ReadLine();
                    decimal.TryParse(input, out b);

                } while (a == 0);

                decimal linearEquationResult = CalculateEquation(a, b);
                Console.WriteLine("x = -({0}) / {1}: {2:F3}", b, a, linearEquationResult);

                break;
            case 4: break;
        }
    }

    static decimal CalculateEquation(decimal a, decimal b)
    {
        decimal result = (-1) * (b / a);

        return result;
    }

    static decimal CalculateAverage(string input)
    {
        decimal result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                result += input[i] - '0';
            }
        }

        result = result / input.Length;

        return result;
    }

    static string ReversedDecimalNum(decimal number)
    {
        string numToString = Convert.ToString(number);
        StringBuilder sb = new StringBuilder();

        for (int i = numToString.Length - 1; i >= 0; i--)
        {
            sb.Append(numToString[i]);
        }

        string result = sb.ToString();

        return result;
    }
}