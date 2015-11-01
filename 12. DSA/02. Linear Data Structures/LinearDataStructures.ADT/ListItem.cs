namespace LinearDataStructures.ADT
{
    public class ListItem<T>
    {
        public T Value { get; set; }

        public ListItem<T> PreviousItem { get; set; }

        public ListItem<T> NextItem { get; set; }
    }
}
