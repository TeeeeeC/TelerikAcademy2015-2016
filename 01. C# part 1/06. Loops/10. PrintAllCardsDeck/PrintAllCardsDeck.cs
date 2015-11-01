using System;
using System.Text;

class PrintAllCardsDeck
{
    static void Main()
    {
        /*
         Problem 4. Print a Deck of 52 Cards
            Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
            The card faces should start from 2 to A.
            Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
         */
        Console.WriteLine(" Print All Standart Cards \n");
        Console.OutputEncoding = Encoding.Unicode;

        for (int cardNum = 2; cardNum < 15; cardNum++)
        {
            for(int cardSymbol = 3; cardSymbol < 7; cardSymbol++)
            {
                if (cardNum < 11)
                {
                    switch (cardSymbol)
                    {
                        case 3: Console.Write(" {0}{1}, ", cardNum, (char)cardSymbol); break;
                        case 4: Console.Write(" {0}{1}, ", cardNum, (char)cardSymbol); break;
                        case 5: Console.Write(" {0}{1}, ", cardNum, (char)cardSymbol); break;
                        case 6: Console.Write(" {0}{1}, ", cardNum, (char)cardSymbol); break;
                    }
                }
                else
                {
                    switch (cardNum)
                    {
                        case 11: Console.Write(" J{0}, ", (char)cardSymbol); break;
                        case 12: Console.Write(" Q{0}, ", (char)cardSymbol); break;
                        case 13: Console.Write(" K{0}, ", (char)cardSymbol); break;
                        case 14: Console.Write(" A{0}, ", (char)cardSymbol); break;
                    }
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

