namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var currItem in this.Items)
            {
                if (currItem.CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            var sorter = new Quicksorter<T>();
            sorter.Sort(this.Items);

            int left = 0;
            int rigth = this.items.Count - 1;
            while (left <= rigth)
            {
                int middle = left + (rigth - left) / 2;
                if (this.items[middle].CompareTo(item) < 0)
                {
                    left = middle + 1;
                }
                else if(this.items[middle].CompareTo(item) > 0)
                {
                    rigth = middle - 1;
                }
                else if(this.items[middle].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            var rand = new Random();
            for (int i = 0; i < this.items.Count - 1; i++)
            {
                int n = rand.Next(i + 1, this.items.Count - 1);
                T storedValue = this.items[i];
                this.items[i] = this.items[n];
                this.items[n] = storedValue;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
