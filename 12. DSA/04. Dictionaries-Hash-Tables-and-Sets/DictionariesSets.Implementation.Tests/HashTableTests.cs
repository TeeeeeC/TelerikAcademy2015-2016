namespace DictionariesSets.Implementation.Tests
{
    using System;

    using Implementation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void TestCapacityProperty()
        {
            var table = new HashTable<int, int>();
            Assert.AreEqual(16, table.Capacity);
        }

        [TestMethod]
        public void TestCountProperty()
        {
            var table = new HashTable<int, int>();
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        public void TestKeysProperty()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            Assert.AreEqual(1, table.Keys.Count);
        }

        [TestMethod]
        public void TestIndexerPropertyWithValidIndex()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            Assert.AreEqual(6, table["Pesho"]);
        }

        [TestMethod]
        public void TestIndexerPropertySetValue()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            table["Pesho"] = 5;
            Assert.AreEqual(5, table["Pesho"]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIndexerSetValueWithInvalidKeyShouldThrow()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            table["Peso"] = 5;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIndexerPropertyWithInvalidIndexShouldThrow()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            var value = table[string.Empty];
        }

        [TestMethod]
        public void TestAddShouldProperlyWork()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            Assert.AreEqual(1, table.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddWithExistingKeyShouldThrow()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            table.Add("Pesho", 6);
        }

        [TestMethod]
        public void TestAddWithCapacityAtleast75Percent()
        {
            var table = new HashTable<string, int>();
            for (int i = 0; i < 12; i++)
            {
                table.Add("Pesho" + i, 6);
            }

            Assert.AreEqual(32, table.Capacity);
        }

        [TestMethod]
        public void TestFindShouldProperlyWork()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);

            Assert.AreEqual(6, table.Find("Pesho"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindWithInvalidKey()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);

            var value = table.Find("Peho");
        }

        [TestMethod]
        public void TestRemoveShouldProperlyWork()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
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
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            table.Clear();
            Assert.AreEqual(0, table.Count);
            Assert.AreEqual(16, table.Capacity);
        }

        [TestMethod]
        public void TestHashTableEnummerator()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            table.GetEnumerator();
        }
    }
}
