using System;
using System.Linq;
using System.Collections.Generic;

class GreedyDwarf
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] valleyStr = text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> valley = new List<int>();

        foreach(string item in valleyStr)
        {
            valley.Add(Convert.ToInt32(item));
        }

        int numOfPattern = int.Parse(Console.ReadLine());
        List<int> finalSum = new List<int>();

        for (int i = 0; i < numOfPattern; i++)
        {
            text = Console.ReadLine();
            string[] currPatternStr = text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> currPattern = new List<int>();

            foreach (string item in currPatternStr)
            {
                currPattern.Add(Convert.ToInt32(item));
            }

            int indexValley = 0;
            int indexPattern = 0;
            List<int> oldIndexPath = new List<int>();
            List<int> collectedCoins = new List<int>();

            while(true)
            {
                if(indexValley < 0 || indexValley > valley.Count - 1)
                {
                    int currSum = 0;

                    foreach (int num in collectedCoins)
                    {
                        currSum += num;
                    }
                    finalSum.Add(currSum);
                    break;
                }

                if(oldIndexPath.Exists(x => x == indexValley))
                {
                    int currSum = 0;

                    foreach (int num in collectedCoins)
                    {
                        currSum += num;
                    }
                    finalSum.Add(currSum);
                    break;
                }

                oldIndexPath.Add(indexValley);
                collectedCoins.Add(valley[indexValley]);
                indexValley += currPattern[indexPattern];
                
                if(indexPattern < currPattern.Count - 1)
                {
                    indexPattern++;
                }
                else
                {
                    indexPattern = 0;
                }
            }
        }

        Console.WriteLine(finalSum.Max());
    }
}
