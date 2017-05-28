namespace AdvancedDataStructures.Tasks
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;
        private bool ascending;

        public PriorityQueue(bool ascending = true)
        {
            this.data = new List<T>();
            this.ascending = ascending;
        }

        public int Count => this.data.Count;

        public void Enqueue(T child)
        {
            if (child == null)
            {
                throw new ArgumentException("The value cannot be null!");
            }

            if (this.data.Count == 0)
            {
                this.data.Add(child);
            }
            else
            {
                this.data.Add(child);
                var parentIndex = (int)Math.Floor((double)(this.data.Count - 2) / 2);
                var parent = this.data[parentIndex];
                var childIndex = this.data.Count - 1;

                this.Reorder(parent, child, parentIndex, childIndex);
            }
        }

        public T Dequeue()
        {
            if (this.data.Count == 0)
            {
                return default(T);
            }

            T result = this.data[0];

            int lastIndex = this.data.Count - 1;
            this.data[0] = this.data[lastIndex];
            this.data.RemoveAt(lastIndex);

            if (this.ascending)
            {
                this.MinHeapify(0);
            }
            else
            {
                this.MaxHeapify(0);
            }

            return result;
        }

        

        public T Peek()
        {
            return this.data[0];
        }

        private void Reorder(T parent, T child, int parentIndex, int childIndex)
        {
            while (this.CompareAscending(parent, child))
            {
                this.data[parentIndex] = child;
                this.data[childIndex] = parent;

                if (parentIndex == 0)
                {
                    break;
                }

                child = this.data[parentIndex];
                childIndex = parentIndex;
                parentIndex = (int)Math.Floor((double)(parentIndex - 1) / 2);
                parent = this.data[parentIndex];
            }
        }

        private void MaxHeapify(int parentIndex)
        {
            var left = (2 * parentIndex) + 1;
            var right = (2 * parentIndex) + 2;
            var max = parentIndex;
            if (left < this.data.Count && this.data[left].CompareTo(this.data[max]) > 0)
            {
                max = left;
            }
            if (right < this.data.Count && this.data[right].CompareTo(this.data[max]) > 0)
            {
                max = right;
            }

            if (max.CompareTo(parentIndex) != 0)
            {
                T storedValue = this.data[max];
                this.data[max] = this.data[parentIndex];
                this.data[parentIndex] = storedValue;
                MaxHeapify(max);
            }

        }

        private void MinHeapify(int parentIndex)
        {
            var left = (2 * parentIndex) + 1;
            var right = (2 * parentIndex) + 2;
            var min = parentIndex;
            if (left < this.data.Count && this.data[left].CompareTo(this.data[min]) < 0)
            {
                min = left;
            }
            if (right < this.data.Count && this.data[right].CompareTo(this.data[min]) < 0)
            {
                min = right;
            }

            if (min.CompareTo(parentIndex) != 0)
            {
                T storedValue = this.data[min];
                this.data[min] = this.data[parentIndex];
                this.data[parentIndex] = storedValue;
                MinHeapify(min);
            }

        }

        private bool CompareAscending(T parent, T child)
        {
            if (this.ascending)
            {
                return parent.CompareTo(child) > 0;
            }

            return parent.CompareTo(child) < 0;
        }
    }
}
