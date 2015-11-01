using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void ToStingShoulReturnStringValue()
        {
            var cards = new List<ICard>() { new Card(CardFace.Ace, CardSuit.Clubs) };
            var hand = new Hand(cards);

            Assert.IsInstanceOfType(hand.ToString(), typeof(string));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ToStingShoulThrowAnExceptionIfThereAreNoCards()
        {
            var cards = new List<ICard>() { new Card(CardFace.Ace, CardSuit.Clubs) };
            var hand = new Hand(null);
            var result = hand.ToString();
        }
    }
}