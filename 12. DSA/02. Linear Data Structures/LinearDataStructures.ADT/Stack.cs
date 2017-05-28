namespace LinearDataStructures.ADT
{
    public class Stack<T>
    {
        private int initialSize = 16;
        private T[] data;
        private int index;

        public Stack()
        {
            this.data = new T[initialSize];
            this.index = 0;
        }

        public int Count 
        {
            get { return index; } 
        }

        public T Peek 
        {
            get { return this.data[this.Count - 1]; }
        }

        public void Push(T value)
        {
            if(index >= this.data.Length)
            {
                this.ResizeArray();
            }

            this.data[index] = value;
            index++;
        }

        public T Pop()
        {
            index--;
            return this.data[this.Count];
        }

        private void ResizeArray()
        {
            initialSize *= 2;
            T[] dataCopy = new T[initialSize];
            this.data.CopyTo(dataCopy, 0);

            this.data = new T[initialSize];
            dataCopy.CopyTo(this.data, 0);
        }
    }
}
