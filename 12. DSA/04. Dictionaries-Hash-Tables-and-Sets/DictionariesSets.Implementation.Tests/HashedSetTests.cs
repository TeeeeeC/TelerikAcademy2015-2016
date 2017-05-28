namespace DictionariesSets.Implementation.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashedSetTests
    {
        [TestMethod]
        public void TestCapacityProperty()
        {
            var table = new HashedSet<int>();
            Assert.AreEqual(16, table.Capacity);
        }

        [TestMethod]
        public void TestCountProperty()
        {
            var table = new HashedSet<int>();
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        public void TestAddShouldProperlyWork()
        {
            var table = new HashedSet<string>();
            table.Add("Pesho");
            Assert.AreEqual(1, table.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddWithExistingKeyShouldThrow()
        {
            var table = new HashedSet<string>();
            table.Add("Pesho");
            table.Add("Pesho");
        }

        [TestMethod]
        public void TestAddWithCapacityAtleast75Percent()
        {
            var table = new HashedSet<string>();
            for (int i = 0; i < 12; i++)
            {
                table.Add("Pesho" + i);
            }

            Assert.AreEqual(32, table.Capacity);
        }

        [TestMethod]
        public void TestFindShouldProperlyWork()
        {
            var table = new HashedSet<string>();
            table.Add("Pesho");

            Assert.AreEqual(true, table.Find("Pesho"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindWithInvalidKey()
        {
            var table = new HashedSet<string>();
            table.Add("Pesho");

            var value = table.Find("Peho");
        }

        [TestMethod]
        public void TestRemoveShouldProperlyWork()
        {
            var table = new HashedSet<string>();
            table.Add("Pesho");
            table.Remove("Pesho");
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveWithInvalidKeyShouldThrow()
        {
            var table = new HashTable<string, int>();
            table.Remove("Pesho");
        }

        [TestMethod]
        public void TestClearShouldProperlyWork()
        {
            var table = new HashedSet<string>();
            table.Add("Pesho");
            table.Clear();
            Assert.AreEqual(0, table.Count);
            Assert.AreEqual(16, table.Capacity);
        }

        [TestMethod]
        public void TestUnionShouldProperlyWork()
        {
            var set1 = new HashedSet<string>();
            set1.Add("Pesho");
            var set2 = new HashedSet<string>();
            set2.Add("Gosho");

            var result = set1.Union(set2);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void TestIntersectShouldProperlyWork()
        {
            var set1 = new HashedSet<string>();
            set1.Add("Pesho");
            set1.Add("Tosho");
            var set2 = new HashedSet<string>();
            set2.Add("Pesho");
            set2.Add("Maria");

            var result = set1.Intersect(set2);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void TestHashedSetEnummerator()
        {
            var table = new HashedSet<string>();
            table.Add("Pesho");
            foreach (var value in table)
            {
                Assert.AreEqual("Pesho", value);
            }
        }
    }
}
