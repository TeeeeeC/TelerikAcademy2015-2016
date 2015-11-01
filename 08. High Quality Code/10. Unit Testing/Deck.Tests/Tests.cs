using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Deck.Tests
{
    [TestFixture]
    public class DeckTests
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(4)]
        public void GettingNextCardsLeftShoudProperlyWork(int count)
        {
            var deck = new Deck();

            for (int i = 0; i < count; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(24 - count, deck.CardsLeft, string.Format("The deck must have count cards!"));
        }

        [TestCase(24)]
        public void Getting24NextCardsLeftShoudThrowAnExcepetion(int count)
        {
            var deck = new Deck();

            for (int i = 0; i < count; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws(typeof(ArgumentException),
                () => { deck.GetNextCard(); });
        }

        [Test]
        public void ChangingTrumpCardShouldProperlyWork()
        {
            var deck = new Deck();
            var trumpCard = new Card(CardSuit.Heart, CardType.Ace);
            deck.ChangeTrumpCard(trumpCard);

            Assert.AreEqual(deck.GetTrumpCard, trumpCard, string.Format("The trump card is not change properly!"));
        }
    }
}
