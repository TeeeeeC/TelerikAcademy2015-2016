using System;

class FibonacciSequence
{
    static void Main()
    {
        string strN = "";
        int numberN = 0;

        Console.WriteLine(" Fibonacci Sequence\n");

        do
        {
            Console.Write(" Insert number N: ");
            strN = Console.ReadLine();
            int.TryParse(strN, out numberN);

        } while ((!(int.TryParse(strN, out numberN))) ||(numberN < 3));

        int lastSum = 1, previosSum = 0, result = 0;

        Console.WriteLine();
        Console.Write(" For N = {0}: {1},{2},", numberN, previosSum, lastSum);

        for (int i = 0; i < numberN; i++)
        {
            result = lastSum + previosSum;
            previosSum = lastSum;
            lastSum = result;
            Console.Write("{0},", lastSum);
        }
        Console.WriteLine("\n");
    }
}
