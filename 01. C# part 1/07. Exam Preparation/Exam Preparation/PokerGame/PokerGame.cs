using System;

class PokerGame
{
    static void Main()
    {
        string card1 = Console.ReadLine();
        string card2 = Console.ReadLine();
        string card3 = Console.ReadLine();
        string card4 = Console.ReadLine();
        string card5 = Console.ReadLine();

        int num1, num2, num3, num4, num5;

        if (card1 == card2 && card2 == card3 && card3 == card4 && card4 == card5)
        {
            Console.WriteLine("Impossible");
        }
        else if ((card1 == card2 && card2 == card3 && card3 == card4) || (card1 == card2 && card2 == card3 && card3 == card5)
            || (card1 == card2 && card2 == card4 && card4 == card5) || (card1 == card3 && card3 == card4 && card4 == card5)
            || (card2 == card3 && card3 == card4 && card4 == card5))
        {
            Console.WriteLine("Four of a Kind");
        }
        else if ((card1 == card2 && card2 == card3 && card4 == card5) || (card1 == card2 && card2 == card4 && card3 == card5)
            || (card1 == card2 && card2 == card5 && card3 == card4) || (card2 == card3 && card3 == card4 && card1 == card5)
            || (card2 == card3 && card3 == card5 && card1 == card4) || (card3 == card4 && card4 == card5 && card1 == card2))
        {
            Console.WriteLine("Full House");
        }
        else if (card1 == card2)
        {
            Console.WriteLine("Straight");
        }
        else if ((card1 == card2 && card2 == card3 && card4 != card5) || (card1 == card2 && card2 == card4 && card3 != card5)
            || (card1 == card2 && card2 == card5 && card3 != card4) || (card2 == card3 && card3 == card4 && card1 != card5)
            || (card2 == card3 && card3 == card5 && card1 != card4) || (card3 == card4 && card4 == card5 && card1 != card2))
        {
            Console.WriteLine("Three of a Kind");
        }
        else if((card1 == card2 && card3 == card4) || (card1 == card2 && card3 == card5) || (card1 == card3 && card2 == card4)
           || (card1 == card3 && card2 == card5) || (card1 == card4 && card2 == card3) || (card1 == card4 && card2 == card5)
            || (card1 == card5 && card2 == card3) || (card1 == card5 && card2 == card4) || (card1 == card5 && card3 == card4))
        {
            Console.WriteLine("Two Pairs");
        }
        else if((card1 == card2) || (card1 == card3) || (card1 == card4) || (card1 == card5)
            || (card2 == card3) || (card2 == card4) || (card2 == card5) || (card3 == card4) || (card3 == card5) || (card4 == card5))
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            Console.WriteLine("Nothing");
        }
    }
}
