using System;

class CheckBracketsInExpression
{
    private static bool IsSign(char ch)
    {
        char[] signs = new char[] { '+', '*', '/', '-' };

        for (int i = 0; i < signs.Length; i++)
        {
            if (ch == signs[i])
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        /*
         Problem 3. Correct brackets
            Write a program to check if in a given expression the brackets are put correctly.
            Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
         */
        Console.Write("Enter expression for check: ");
        string expression = Console.ReadLine();

        bool checkBrackets = true;

        for (int i = 1; i < expression.Length - 1; i++)
        {
            char prevChar = expression[i - 1];
            char currChar = expression[i];
            char nextChar = expression[i + 1];

            if((prevChar == '(' && currChar == ')') || (prevChar == '(' && nextChar == ')'))
            {
                checkBrackets = false;
            }
            else if ((IsSign(prevChar) && currChar == ')') || (IsSign(currChar) && nextChar == ')'))
            {
                checkBrackets = false;
            }
            else if ((Char.IsDigit(prevChar) && currChar == '(') || (Char.IsDigit(currChar) && nextChar == '('))
            {
                checkBrackets = false;
            }
            else if ((Char.IsDigit(currChar) && prevChar == ')') || (Char.IsDigit(nextChar) && currChar == ')'))
            {
                checkBrackets = false;
            }
            if ((prevChar == ')' && currChar == '(') || (currChar == ')' && nextChar == '('))
            {
                checkBrackets = false;
            }    
        }

        int indexLeftBracket = 0, indexRightBracket = 0, index = 0;
        int bracketLeft = 0, bracketRight = 0;

        while (bracketLeft != -1 && bracketRight != -1)
        {
            bracketLeft = expression.IndexOf("(", indexLeftBracket);
            bracketRight = expression.IndexOf(")", indexRightBracket);

            if (bracketLeft != -1)
            {
                index++;
            }
            if (bracketRight != -1)
            {
                index--;
            }

            indexLeftBracket = bracketLeft + 1;
            indexRightBracket = bracketRight + 1;
        }
        
        if (checkBrackets && index == 0)
        {
            Console.WriteLine(checkBrackets);
        }
        else
        {
            Console.WriteLine(checkBrackets = false);
        }
    }
}
