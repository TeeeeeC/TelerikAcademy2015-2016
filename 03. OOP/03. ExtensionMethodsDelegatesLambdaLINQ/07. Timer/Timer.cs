namespace _07.Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        public delegate void RepeatMethod(int t);

        public static void Main()
        {
            RepeatMethod t = delegate(int time)
            {
                for (int i = 10; i > 0; i--)
                {
                    Thread.Sleep(time);
                    Console.WriteLine("{0}s", i);
                }
                Thread.Sleep(time);
                Console.WriteLine("BOOM!");
            };
            t(1000);
        }
    }
}
