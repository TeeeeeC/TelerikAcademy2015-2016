using System;

class Enigmanation
{
    static void Main()
    {
        string expression = Console.ReadLine();

        decimal result = 0;
        decimal currBracketResult = 0;

        char currentOperator = '+';
        char currentBracketOperator = '+';

        bool inBracket = false;

        foreach(char symbol in expression)
        {
            if (symbol == '(')
            {
                inBracket = true;
                continue;
            }

            if (symbol == ')')
            {
                inBracket = false;

                switch (currentOperator)
                {
                    case '+': result += currBracketResult; break;
                    case '-': result -= currBracketResult; break;
                    case '%': result %= currBracketResult; break;
                    case '*': result *= currBracketResult; break;
                }

                currBracketResult = 0;
                currentBracketOperator = '+';
            }

            if (symbol == '+' ||
                symbol == '-' ||
                symbol == '%' ||
                symbol == '*')
            {
                if (inBracket)
                {
                    currentBracketOperator = symbol;
                }
                else
                {
                    currentOperator = symbol;
                }
            }

            if(char.IsDigit(symbol))
            {
                int currNumber = symbol - '0';

                if (inBracket)
                {
                    switch (currentBracketOperator)
                    {
                        case '+': currBracketResult += currNumber; break;
                        case '-': currBracketResult -= currNumber; break;
                        case '%': currBracketResult %= currNumber; break;
                        case '*': currBracketResult *= currNumber; break;
                    }
                }
                else
                {
                    switch (currentOperator)
                    {
                        case '+': result += currNumber; break;
                        case '-': result -= currNumber; break;
                        case '%': result %= currNumber; break;
                        case '*': result *= currNumber; break;
                    }
                }
            }
        }

        Console.WriteLine("{0:F3}", result);
    }
}