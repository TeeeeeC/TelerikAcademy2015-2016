namespace LinearDataStructures.ADT
{
    public class Queue<T>
    {
        private LinkedList<T> linkedlist;

        public Queue()
        {
            this.linkedlist = new LinkedList<T>();
        }

        public int Count
        {
            get { return this.linkedlist.Count; }
        }

        public T Peek 
        {
            get { return this.linkedlist.FirstElement.Value; }
        }

        public void Enqueue(T value)
        {
            this.linkedlist.AddLast(value);
        }

        public T Dequeue()
        {
            return this.linkedlist.RemoveFirst();
        }
    }
}
