using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ToStingShoulReturnStringValue()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);

            Assert.IsInstanceOfType(card.ToString(), typeof(string));
        }
    }
}
