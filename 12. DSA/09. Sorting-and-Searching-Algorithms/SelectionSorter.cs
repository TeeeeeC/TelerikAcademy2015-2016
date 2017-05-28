namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[indexMin]) < 0)
                    {
                        indexMin = j;
                    }
                }

                if (indexMin != i)
                {
                    T storedValue = collection[i];
                    collection[i] = collection[indexMin];
                    collection[indexMin] = storedValue;
                }
            }
        }
    }
}
