using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            var result = string.Empty;

            if (this.Cards == null) 
            {
                throw new ArgumentNullException("There are no cards in hand!");
            }

            foreach (var card in this.Cards)
            {
                result += card.ToString() + "\n";
            }

            return result;
        }
    }
}
