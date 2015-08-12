using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void IsValidHandShoulReturnTrueIfCardsAreFiveAndDifferents()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
            };
            var hand = new Hand(cards);

            Assert.IsTrue(pockerHandChecker.IsValidHand(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsValidHandShoulThrowBecauseOfNumberOfCardsInHand()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
            };
            var hand = new Hand(cards);

            Assert.IsTrue(pockerHandChecker.IsValidHand(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsValidHandShoulThrowBecauseOfTwoTheS()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
            };
            var hand = new Hand(cards);

            Assert.IsTrue(pockerHandChecker.IsValidHand(hand));
        }

        [TestMethod]
        public void IsFlushShoulReturnTrueIfCardsAreTheSameSuit()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
            };
            var hand = new Hand(cards);

            Assert.IsTrue(pockerHandChecker.IsFlush(hand));
        }

        [TestMethod]
        public void IsFlushShoulReturnFalseIfCardsAreNotTheSameSuit()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Hearts),
            };
            var hand = new Hand(cards);

            Assert.IsFalse(pockerHandChecker.IsFlush(hand));
        }

        [TestMethod]
        public void IsFourOfKindShoulReturnTrueIf4OfCardsAreTheSame()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
            };
            var hand = new Hand(cards);

            Assert.IsTrue(pockerHandChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void IsFourOfKindShoulReturnTrueIf4OfCardsAreTheSame1()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
            };
            var hand = new Hand(cards);

            Assert.IsTrue(pockerHandChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void IsFourOfKindShoulReturnTrueIf4OfCardsAreTheSame2()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
            };
            var hand = new Hand(cards);

            Assert.IsTrue(pockerHandChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void IsFourOfKindShoulReturnFalseIf3OfCardsAreTheSame()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
            };
            var hand = new Hand(cards);

            Assert.IsFalse(pockerHandChecker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void IsFourOfKindShoulReturnFalseIf3OfCardsAreTheSame1()
        {
            var pockerHandChecker = new PokerHandsChecker();
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades),
            };
            var hand = new Hand(cards);

            Assert.IsFalse(pockerHandChecker.IsFourOfAKind(hand));
        }
    }
}
