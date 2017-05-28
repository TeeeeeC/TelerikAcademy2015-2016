namespace PrintNestedLoops
{
    using System;

    public class Startup
    {
        private static int[] loops;

        private static void Main()
        {
            Console.Write("Enter number N: ");
            int number = int.Parse(Console.ReadLine());

            loops = new int[number];
            SimulateNestedLoops(0);
        }

        private static void SimulateNestedLoops(int loopsCount)
        {
            if (loopsCount == loops.Length)
            {
                for (int i = 0; i < loops.Length; i++)
                {
                    Console.Write("{0} ", loops[i]);
                }
                Console.WriteLine();
                return;
            }

            for (int i = 1; i <= loops.Length; i++)
            {
                loops[loopsCount] = i;
                SimulateNestedLoops(loopsCount + 1);
            }
        }
    }
}
