namespace CableTvCompany
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static List<Edge> minSpaningTree;
        private static List<Edge> graph;

        static void Main()
        {
            Input();
            Prim();
            Print();
        }

        private static void Print()
        {
            foreach (var edge in minSpaningTree)
            {
                Console.WriteLine("{0} {1} -> {2}", edge.Start, edge.Distance, edge.End);
            }
        }

        private static void Prim()
        {
            minSpaningTree = new List<Edge>();
            var queue = new PriorityQueue<Edge>();
            var used = new bool[graph.Count + 1];
            foreach (Edge edge in graph)
            {
                if (edge.Start == graph[0].Start)
                {
                    queue.Enqueue(edge);
                }
            }

            used[graph[0].Start - 'A'] = true;

            while (queue.Count > 0)
            {
                Edge edge = queue.Dequeue();

                if (!used[edge.End - 'A'])
                {
                    used[edge.End - 'A'] = true; 
                    minSpaningTree.Add(edge);
                    for (int i = 0; i < graph.Count; i++)
                    {
                        if (!minSpaningTree.Contains(graph[i]))
                        {
                            if (edge.End == graph[i].Start && !used[graph[i].End - 'A'])
                            {
                                queue.Enqueue(graph[i]);
                            }
                        }
                    }
                }
            }

        }

        private static void Input()
        {
            graph = new List<Edge>();
            graph.Add(new Edge('A', 5, 'C'));
            graph.Add(new Edge('A', 9, 'D'));
            graph.Add(new Edge('A', 4, 'B'));

            graph.Add(new Edge('B', 4, 'A'));
            graph.Add(new Edge('B', 2, 'D'));

            graph.Add(new Edge('C', 5, 'A'));
            graph.Add(new Edge('C', 20, 'D'));
            graph.Add(new Edge('C', 7, 'E'));

            graph.Add(new Edge('D', 2, 'B'));
            graph.Add(new Edge('D', 9, 'A'));
            graph.Add(new Edge('D', 20, 'C'));
            graph.Add(new Edge('D', 8, 'E'));

            graph.Add(new Edge('E', 7, 'C'));
            graph.Add(new Edge('E', 8, 'D'));
            graph.Add(new Edge('E', 12, 'F'));
        }
    }

    class Edge : IComparable<Edge>
    {
        public Edge(char start, int distance, char end)
        {
            this.Start = start;
            this.Distance = distance;
            this.End = end;
        }

        public char Start { get; set; }

        public int Distance { get; set; }

        public char End { get; set; }

        public int CompareTo(Edge other)
        {
            if (this.Distance > other.Distance)
            {
                return 1;
            }

            return -1;
        }
    }

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public int Count
        {
            get { return this.data.Count; }
        }

        public void Enqueue(T child)
        {
            this.data.Add(child);
            var parentIndex = (this.data.Count - 2) / 2;
            var parent = this.data[parentIndex];
            var childIndex = this.data.Count - 1;

            this.Reorder(parent, child, parentIndex, childIndex);
        }

        public T Dequeue()
        {
            T result = this.data[0];

            int lastIndex = this.data.Count - 1;
            this.data[0] = this.data[lastIndex];
            this.data.RemoveAt(lastIndex);

            this.MinHeapify(0);

            return result;
        }

        public T Peek()
        {
            return this.data[0];
        }

        private void Reorder(T parent, T child, int parentIndex, int childIndex)
        {
            while (parent.CompareTo(child) > 0)
            {
                this.data[parentIndex] = child;
                this.data[childIndex] = parent;

                if (parentIndex == 0)
                {
                    break;
                }

                child = this.data[parentIndex];
                childIndex = parentIndex;
                parentIndex = (parentIndex - 1) / 2;
                parent = this.data[parentIndex];
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
    }
}
