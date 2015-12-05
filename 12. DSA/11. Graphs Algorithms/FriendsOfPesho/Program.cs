namespace FriendsOfPesho
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static int nodesCount;
        private static int edgesCount;
        private static HashSet<int> endNodes;
        private static Dictionary<int, List<Edge>> graph;
        private static List<int> distance;
        private static PriorityQueue<Edge> queue;
        private static int answer;

        static void Main()
        {
            Input();
            distance = new List<int>(Enumerable.Repeat(21, nodesCount + 1));
            queue = new PriorityQueue<Edge>();
            answer = int.MaxValue;

            Dikstra();
            Console.WriteLine(answer);
        }

        private static void Dikstra()
        {
            
            foreach (var start in endNodes)
            {
                int result = 0;
                var visited = new bool[nodesCount + 1];
                var d = new List<int>(distance);
                d[start] = 0;

                queue.Enqueue(new Edge(start, 0));
                while (queue.Count > 0)
                {
                    var current = queue.Dequeue();
                    visited[current.Name] = true;

                    foreach (var node in graph[current.Name])
                    {
                        if (d[node.Name] > d[current.Name] + node.Distance)
                        {
                            d[node.Name] = d[current.Name] + node.Distance;
                            queue.Enqueue(new Edge(node.Name, d[node.Name]));
                        }
                    }

                    while (queue.Count > 0 && visited[queue.Peek().Name])
                    {
                        queue.Dequeue();
                    }
                }

                for (int i = 1; i < d.Count; i++)
                {
                    if (!endNodes.Contains(i))
                    {
                        result += d[i];
                    }
                }

                if (result < answer)
                {
                    answer = result;
                }
            }
        }

        private static void Input()
        {
            var parameters = Console.ReadLine().Split(' ');
            nodesCount = int.Parse(parameters[0]);
            edgesCount = int.Parse(parameters[1]);
            var endsNodeCount = int.Parse(parameters[2]);
            var endNodesArray = Console.ReadLine().Split(' ');
            endNodes = new HashSet<int>();
            foreach (var endNode in endNodesArray)
            {
                endNodes.Add(int.Parse(endNode));
            }

            graph = new Dictionary<int, List<Edge>>();
            for (int i = 1; i <= nodesCount; i++)
            {
                graph.Add(i, new List<Edge>());
            }

            for (int i = 0; i < edgesCount; i++)
            {
                parameters = Console.ReadLine().Split(' ');
                int from = int.Parse(parameters[0]);
                int to = int.Parse(parameters[1]);
                int distance = int.Parse(parameters[2]);

                graph[from].Add(new Edge(to, distance));
                graph[to].Add(new Edge(from, distance));
            }
        }
    }

    class Edge : IComparable<Edge>
    {
        public Edge(int name, int distance)
        {
            this.Name = name;
            this.Distance = distance;
        }

        public int Name { get; set; }

        public int Distance { get; set; }

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
