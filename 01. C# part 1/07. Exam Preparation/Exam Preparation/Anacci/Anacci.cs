using System;

class Anacci
{
    static void Main()
    {
        string firstChar = Console.ReadLine();
        string secondChar = Console.ReadLine();
        int line = int.Parse(Console.ReadLine());

        char firstCh = firstChar[0];
        char secondCh = secondChar[0];
        int firstNum = (int)firstCh - 64;
        int secondNum = (int)secondCh - 64;
        int result = 0;

        if (line < 3)
        {
            if (line == 1)
            {
                Console.WriteLine(firstChar);
            }
            else
            {
                Console.WriteLine(firstChar);
                Console.WriteLine(secondChar + (char)(firstNum + secondNum + 64));
            }
        }
        else
        {
            result = firstNum + secondNum;
            if (result > 26)
            {
                result %= 26;
            }
            firstNum = secondNum;
            secondNum = result;

            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar + (char)(result + 64));

            for (int row = 1; row < line - 1; row++)
            {
                for (int col = 0; col <= 1; col++)
                {
                    result = firstNum + secondNum;

                    if (result > 26)
                    {
                        result %= 26;
                    }

                    firstNum = secondNum;
                    secondNum = result;

                    Console.Write((char)(result + 64) + new string(' ', row));
                }

                Console.WriteLine();
            }
        }
    }
}
