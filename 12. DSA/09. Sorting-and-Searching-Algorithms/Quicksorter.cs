namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int left, int right)
        {
            if (left < right)
            {
                int pivot = GetPartition(collection, left, right);

                QuickSort(collection, left, pivot - 1);
                QuickSort(collection, pivot + 1, right);
            }
        }

        private int GetPartition(IList<T> collection, int left, int right)
        {
            T pivot = collection[right];
            int index = left - 1;
            for (int i = left; i < right; i++)
            {
                if (collection[i].CompareTo(pivot) <= 0)
                {
                    index++;
                    Swap(collection, index, i);
                }   
            }

            Swap(collection, index + 1, right);

            return index + 1;
        }

        private void Swap(IList<T> collection, int index, int i)
        {
            T storedValue = collection[index];
            collection[index] = collection[i];
            collection[i] = storedValue;
        }
    }
}
