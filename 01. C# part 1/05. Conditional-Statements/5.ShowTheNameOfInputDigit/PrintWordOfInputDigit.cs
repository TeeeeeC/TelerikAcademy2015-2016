using System;

class PrintWordOfInputDigit
{
    static void Main()
    {
        /*
         Problem 8. Digit as Word
            Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
            Print “not a digit” in case of invalid input.
            Use a switch statement.
         */
        Console.Write(" Inser the digit [0-9]: ");
        string ch = Console.ReadLine();

 
        switch (ch)
        {
            case "0": Console.WriteLine(" The digit is 0 -> Null! "); break;
            case "1": Console.WriteLine(" The digit is 1 -> One! "); break;
            case "2": Console.WriteLine(" The digit is 2 -> Two! "); break;
            case "3": Console.WriteLine(" The digit is 3 -> Three! "); break;
            case "4": Console.WriteLine(" The digit is 4 -> Four! "); break;
            case "5": Console.WriteLine(" The digit is 5 -> Five! "); break;
            case "6": Console.WriteLine(" The digit is 6 -> Six! "); break;
            case "7": Console.WriteLine(" The digit is 7 -> Seven! "); break;
            case "8": Console.WriteLine(" The digit is 8 -> Eight! "); break;
            case "9": Console.WriteLine(" The digit is 9 -> Nine! "); break;
            default: Console.WriteLine(" Not a digit! "); break;
        }
    }
}

