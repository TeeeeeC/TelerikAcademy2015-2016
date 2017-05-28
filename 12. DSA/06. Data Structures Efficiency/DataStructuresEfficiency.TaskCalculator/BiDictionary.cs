namespace DataStructuresEfficiency.TaskCalculator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class BiDictionary<K1, K2, V> : IEnumerable<Data<K1, K2, V>>
    {
        private int initialSize;

        private LinkedList<Data<K1, K2, V>>[] data;

        private int counter;

        public BiDictionary()
        {
            this.initialSize = 16;
            this.data = new LinkedList<Data<K1, K2, V>>[this.initialSize];
            this.counter = 0;
        }

        public int Count
        {
            get { return this.counter; }
        }

        public int Capacity
        {
            get { return this.data.Length; }
        }

        public void Add(K1 key1, K2 key2, ICollection<V> value)
        {
            var hash = key1.GetHashCode();
            hash = Math.Abs(hash % this.Capacity);

            var hash1 = key2.GetHashCode();
            hash1 = Math.Abs(hash1 % this.Capacity);

            if (this.data[hash] == null)
            {
                this.data[hash] = new LinkedList<Data<K1, K2, V>>();
            }

            if (this.data[hash1] == null)
            {
                this.data[hash1] = new LinkedList<Data<K1, K2, V>>();
            }

            var existKey1 = this.data[hash].Any(p => p.Key1.Equals(key1));
            if (existKey1)
            {
                throw new ArgumentException("This key1 already exist!");
            }

            var existKey2 = this.data[hash].Any(p => p.Key2.Equals(key2));
            if (existKey2)
            {
                throw new ArgumentException("This key2 already exist!");
            }

            var data = new Data<K1, K2, V>
            {
                Key1 = key1,
                Key2 = key2,
                Value = new List<V>()
            };

            data.Value = value;

            this.data[hash].AddLast(data);
            this.data[hash1].AddLast(data);
            this.counter++;

            if (this.Count >= 0.75 * this.Capacity)
            {
                this.counter = 0;
                this.ResizeDataCapacity();
            }
        }

        public ICollection<V> Find(K1 key1 = default(K1), K2 key2 = default(K2))
        {
            var hash1 = key1.GetHashCode();
            hash1 = Math.Abs(hash1 % this.Capacity);

            if (this.data[hash1] == null)
            {
                this.data[hash1] = new LinkedList<Data<K1, K2, V>>();
            }

            var existKey1 = this.data[hash1].FirstOrDefault(p => p.Key1.Equals(key1));
            if (existKey1 != null)
            {
                return existKey1.Value;
            }

            var hash2 = key2.GetHashCode();
            hash2 = Math.Abs(hash2 % this.Capacity);
            if (this.data[hash2] == null)
            {
                this.data[hash2] = new LinkedList<Data<K1, K2, V>>();
            }

            var existKey2 = this.data[hash2].FirstOrDefault(p => p.Key2.Equals(key2));
            if (existKey2 == null)
            {
                throw new ArgumentException("This key2 already exist!");
            }

            return existKey2.Value;
        }

        public void Remove(K1 key1, K2 key2)
        {
            var hash1 = key1.GetHashCode();
            hash1 = Math.Abs(hash1 % this.Capacity);

            if (this.data[hash1] == null)
            {
                this.data[hash1] = new LinkedList<Data<K1, K2, V>>();
            }

            var existKey1 = this.data[hash1].FirstOrDefault(p => p.Key1.Equals(key1));
            if (existKey1.Key1 == null)
            {
                throw new ArgumentException("This key1 does not exist!");
            }

            var hash2 = Math.Abs(key2.GetHashCode() % this.Capacity);
            var existKey2 = this.data[hash2].FirstOrDefault(p => p.Key1.Equals(key1));
            if (existKey2.Key2 == null)
            {
                throw new ArgumentException("This key2 does not exist!");
            }

            this.data[hash1].Remove(existKey1);
            this.data[hash2].Remove(existKey2);
            this.counter--;
        }

        public void Clear()
        {
            this.data = new LinkedList<Data<K1, K2, V>>[this.initialSize];
            this.counter = 0;
        }

        public IEnumerator<Data<K1, K2, V>> GetEnumerator()
        {
            foreach (var collection in this.data)
            {
                if (collection != null)
                {
                    foreach (var pair in collection)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void ResizeDataCapacity()
        {
            var dataCopy = new LinkedList<Data<K1, K2, V>>[this.initialSize];
            this.data.CopyTo(dataCopy, 0);

            this.initialSize *= 2;
            this.data = new LinkedList<Data<K1, K2, V>>[this.initialSize];

            foreach (var collection in dataCopy)
            {
                if (collection != null)
                {
                    foreach (var data in collection)
                    {
                        this.Add(data.Key1, data.Key2, data.Value);
                    }
                }
            }
        }
    }
}
