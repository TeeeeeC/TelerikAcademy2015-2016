namespace _2.DefiningClassesPart2
{
    using System;

    public class GenericList<T> where T : IComparable<T>
    {
        private const int InitialSize = 16;

        private T[] data;
        private int index;

        public GenericList() 
            : this(InitialSize)
        {
        }

        public GenericList(int initialSize)
        {
            if (initialSize < 1)
            {
                throw new ArgumentOutOfRangeException("Initial size must be bigger than 0!");
            }
            this.data = new T[initialSize];
            this.index = 0;
        }

        public int Count
        {
            get
            {
                return this.index;
            }
            private set
            {
                this.index = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public T this [int index]
        {
            get
            {
                if (index >= 0 && index < this.Count)
                {
                    return this.data[index];
                }
                else
                {
                   throw new ArgumentOutOfRangeException("Index out of range!");
                }
            }
        }

        public void Add(T element)
        {
            if (this.Capacity == this.index)
            {
                ResizeArr();
            }

            this.data[this.index] = element;
            this.index++;
        }


        public void RemoveAt(int position)
        {
            if(position < 0 && position > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }

            if(position == this.Count - 1)
            {
                this.Count--;
            }
            else
            {
                for (int i = position; i < this.Count - 1; i++)
                {
                    this.data[i] = this.data[i + 1];
                }
                this.Count--;
            }
        }

        public void Insert(T element, int position)
        {
            if (position < 0 && position > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }

            if (this.Capacity == this.Count)
            {
                ResizeArr();
            }

            for (int i = this.Count; i >= 0; i--)
            {
                if(position == i)
                {
                    this.data[position] = element;
                    break;
                }
                else
                {
                    this.data[i] = this.data[i - 1];
                }
            }
        }

        public int FindElement(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (element.Equals(this.data[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        private void ResizeArr()
        {
            this.data.CopyTo(this.data = new T[this.Capacity * 2], 0);
        }

        public void Clear()
        {
            this.data = new T[InitialSize];
            this.index = 0;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }

        public T Min()    
        {
            if (this.Count > 0)
            {
                T min = this.data[0];
                for (int i = 1; i < this.Count; i++)
                {
                    if (min.CompareTo(this.data[i]) > 0)
                    {
                        min = this.data[i];
                    }
                }

                return min;
            }

            return default(T);
        }

        public T Max()
        {
            if (this.Count > 0)
            {
                T max = this.data[0];
                for (int i = 1; i < this.Count; i++)
                {
                    if (max.CompareTo(this.data[i]) < 0)
                    {
                        max = this.data[i];
                    }
                }

                return max;
            }

            return default(T);
        }
    }
}
