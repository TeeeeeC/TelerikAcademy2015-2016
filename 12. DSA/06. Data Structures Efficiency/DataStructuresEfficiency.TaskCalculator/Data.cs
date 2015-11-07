namespace DataStructuresEfficiency.TaskCalculator
{
    using System.Collections.Generic;

    public class Data<K1, K2, V>
    {
        public K1 Key1 { get; set; }

        public K2 Key2 { get; set; }

        public ICollection<V> Value { get; set; }
    }
}
