namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            MergeSort(collection);
        }

        private IList<T> MergeSort(IList<T> collection)
        {
            if (collection.Count <= 1)
                return collection;

            int mid = collection.Count / 2;

            IList<T> left = new List<T>();
            IList<T> right = new List<T>();

            for (int i = 0; i < mid; i++)
                left.Add(collection[i]);

            for (int i = mid; i < collection.Count; i++)
                right.Add(collection[i]);

            collection.Clear();

            return Merge(collection, MergeSort(left), MergeSort(right));
        }

        private IList<T> Merge(IList<T> collection, IList<T> left, IList<T> right)
        {
            while (left.Count > 0 && right.Count > 0)
                if (((IComparable)left[0]).CompareTo(right[0]) > 0)
                {
                    collection.Add(right[0]);
                    right.RemoveAt(0);
                }
                else
                {
                    collection.Add(left[0]);
                    left.RemoveAt(0);
                }

            for (int i = 0; i < left.Count; i++)
                collection.Add(left[i]);

            for (int i = 0; i < right.Count; i++)
                collection.Add(right[i]);

            return collection;
        }
    }
}
