namespace LinearDataStructures.ADTConsoleClient
{
    using System;

    using ADT;

    public class ADTConsoleClient
    {
        public static void Main()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(linkedList.Count);

            linkedList.AddLast(4);
            linkedList.RemoveLast();

            Console.WriteLine(new string('-', 60));
            
            var stack = new Stack<string>();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek);
            var last = stack.Pop();
            Console.WriteLine(last);
            Console.WriteLine(stack.Peek);
            for (int i = 0; i < 16; i++)
            {
                stack.Push(i + string.Empty);
            }

            Console.WriteLine(stack.Count); 

            Console.WriteLine(new string('-', 60));

            var queue = new Queue<string>();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek);
            var first = queue.Dequeue();
            Console.WriteLine(first);
            Console.WriteLine(queue.Peek);
        }
    }
}
