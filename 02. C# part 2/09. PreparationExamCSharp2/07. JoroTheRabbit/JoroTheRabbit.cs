using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class JoroTheRabbit
{
    static void Main()
    {
        var text = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        var numbers  = new List<int>();

        foreach(string nums in text)
        {
            numbers.Add(int.Parse(nums));
        }

        int bestPath = 0;

        for (int start = 0; start < numbers.Count; start++)
        {
            for (int step = 1; step < numbers.Count; step++)
            {
                int index = start;
                int currPath = 1;
                int next = index + step;

                if (next >= numbers.Count)
                {
                    next -= numbers.Count;
                }

                while(numbers[index] < numbers[next])
                {
                    currPath++;
                    index = next;
                    next = (index + step);

                    if (next >= numbers.Count)
                    {
                        next -= numbers.Count;
                    }
                }

                if (bestPath < currPath)
                {
                    bestPath = currPath;    
                }
            }
        }

        Console.WriteLine(bestPath);
    }
}