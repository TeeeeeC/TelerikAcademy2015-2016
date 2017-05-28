using System;
using System.Collections.Generic;
using System.Text;

class SpecialValue
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        var numbers = new List<List<int>>();

        for (int i = 0; i < rows; i++)
        {
            string[] text = Console.ReadLine().Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            var lineNums = new List<int>();

            for (int j = 0; j < text.Length; j++)
            {
                int number = int.Parse(text[j]);
                lineNums.Add(number);
            }
            numbers.Add(lineNums);
        }

        int pathPassed = 0;
        int currSpecialValue = 0;
        int maxSpecialValue = 0;
        int row = 0, col = 0;
        int currRow = 0, currCol = 0;
        var visitedPath = new List<int>();
        bool isVisitedRow = false;
        bool isVisitedCol = false;

        while(true)
        {
            if (row == 0 && col == numbers[0].Count)
            {
                Console.WriteLine(maxSpecialValue);
                break;
            }

            var currListOfNums = numbers[currRow];
            visitedPath.Add(currRow);
            visitedPath.Add(currCol);

            if(currListOfNums[currCol] < 0)
            {
                pathPassed++;
                currSpecialValue = pathPassed + Math.Abs(currListOfNums[currCol]);
                pathPassed = 0;
                col++;
                visitedPath.Clear();
                currRow = row;
                currCol = col;

                if (currSpecialValue > maxSpecialValue)
                {
                    maxSpecialValue = currSpecialValue;
                }
                currSpecialValue = 0;
            }
            else
            {
                pathPassed++;
                currCol = currListOfNums[currCol];

                if(currRow < rows - 1)
                {
                    currRow++;
                }
                else
                {
                    currRow = 0;
                }

                for(int even = 0; even < visitedPath.Count; even += 2)
                {
                    if(visitedPath[even] == currRow)
                    {
                        isVisitedRow = true;
                    }
                }

                for (int odd = 1; odd < visitedPath.Count; odd += 2)
                {
                    if (visitedPath[odd] == currRow)
                    {
                        isVisitedCol = true;
                    }
                }

                if (isVisitedRow && isVisitedCol)
                {
                    if(col > numbers[0].Count)
                    {
                        Console.WriteLine(maxSpecialValue);
                        break;
                    }
                    else
                    {
                        col++;
                        currCol = col;
                        pathPassed = 0;
                    }
                }
                else
                {
                    isVisitedRow = false;
                    isVisitedCol = false;
                }
            }
        }
    }
}
