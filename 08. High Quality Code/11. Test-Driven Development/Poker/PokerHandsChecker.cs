using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5) 
            {
                throw new ArgumentOutOfRangeException("Ivalid hand, cards must be exactly 5!");
            }

            for (int i = 0, length = hand.Cards.Count; i < length - 1; i++)
            {
                var currentCard = hand.Cards[i];
                for (int j = i + 1; j < length; j++)
                {
                    var nextCard = hand.Cards[j];
                    if (currentCard.Face == nextCard.Face && currentCard.Suit == nextCard.Suit)
                    {
                        throw new ArgumentException("The cards in hand must be unique!");
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var isValidHand = this.IsValidHand(hand);

            if (!isValidHand)
            {
                return false;
            }

            var numberOfTheSameFaceCards = 1;
            for (int i = 0, length = hand.Cards.Count; i < length - 1; i++)
            {
                var currentCard = hand.Cards[i];
                for (int j = i + 1; j < length; j++)
                {
                    var nextCard = hand.Cards[j];
                    if (currentCard.Face == nextCard.Face && currentCard.Suit != nextCard.Suit)
                    {
                        numberOfTheSameFaceCards++;
                    }
                }

                if (numberOfTheSameFaceCards == 4)
                {
                    return true;
                }
                else
                {
                    numberOfTheSameFaceCards = 1;
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            var isValidHand = this.IsValidHand(hand);

            if (!isValidHand) 
            {
                return false;
            }

            for (int i = 0, length = hand.Cards.Count; i < length - 1; i++)
            {
                var currentCard = hand.Cards[i];
                for (int j = i + 1; j < length; j++)
                {
                    var nextCard = hand.Cards[j];
                    if (currentCard.Suit != nextCard.Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}