namespace LinearDataStructures.ADT
{
    using System;

    public class LinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {
        private int counter;

        public LinkedList()
        {
            this.counter = 0;
        }

        public int Count 
        {
            get { return this.counter; }
        }

        public ListItem<T> FirstElement { get; set; }

        public ListItem<T> LastElement { get; set; }

        public void AddLast(T value)
        {
            var listItem = new ListItem<T>
            {
                Value = value,
            };

            if(this.FirstElement == null)
            {
                this.FirstElement = listItem;
                this.LastElement = listItem;
            }
            else
            {
                this.LastElement.NextItem = listItem;
                listItem.PreviousItem = this.LastElement;
                this.LastElement = listItem;
            }

            this.counter++;
        }

        public void RemoveLast()
        {
            if (this.LastElement != null)
            {
                this.LastElement = this.LastElement.PreviousItem;
                this.LastElement.NextItem = null;
                this.counter--;
            }
        }

        public T RemoveFirst()
        {
            T result = this.FirstElement.Value;
            this.FirstElement = this.FirstElement.NextItem;
            this.FirstElement.PreviousItem = null;
            return result;
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var node = this.FirstElement;
            while (node != null)
            {
                yield return node.Value;
                node = node.NextItem;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
