using System;
using System.Collections.Generic;
using System.Text;

class ThreeInOne
{
    static void Main()
    {
        string[] inputFirstTask = Console.ReadLine().Split(',');
        var numbers = new List<int>();

        foreach(string item in inputFirstTask)
        {
            numbers.Add(int.Parse(item));
        }

        int resultFirstTask = FirstTask(numbers);

        string[] inputSecondTask = Console.ReadLine().Split(',');
        int countFriends = int.Parse(Console.ReadLine());
        numbers.Clear();

        foreach (string item in inputSecondTask)
        {
            numbers.Add(int.Parse(item));
        }

        int resultSecondTask = SecondTask(numbers, countFriends);

        string[] inputThirdTask = Console.ReadLine().Split(' ');
        var myMoney = new List<int>();
        var bankMoney = new List<int>();

        for (int i = 0; i < inputThirdTask.Length; i++)
        {
            if (i < 3)
            {
                myMoney.Add(int.Parse(inputThirdTask[i]));
            }
            else
            {
                bankMoney.Add(int.Parse(inputThirdTask[i]));
            }
        }

        int resultThirdTask = ThirdTask(myMoney, bankMoney);

        Console.WriteLine(resultFirstTask);
        Console.WriteLine(resultSecondTask);
        Console.WriteLine(resultThirdTask);
    }

    static int ThirdTask(List<int> myMoney, List<int> bankMoney)
    {
        int countOperations = 0;

        for (int i = 0; i < 2; i++)
        {
            if(myMoney[i] > bankMoney[i])
            {
                int difference = myMoney[i] - bankMoney[i];

                myMoney[i + 1] += difference * 9;
                myMoney[i] = bankMoney[i];
                countOperations += difference;
            }
            else if (myMoney[i] < bankMoney[i])
            {
                int difference = bankMoney[i] - myMoney[i];

                myMoney[i + 1] -= difference * 11;
                myMoney[i] = bankMoney[i];
                countOperations += difference;
            }
        }

        if (myMoney[0] >= bankMoney[0] && myMoney[1] >= bankMoney[1] && myMoney[2] >= bankMoney[2])
        {
            return countOperations;
        }

        return -1;
    }

    static int SecondTask(List<int> numbers, int countFriends)
    {
        numbers.Sort();
        int result = 0;

        for (int i = numbers.Count - 1; i >= 0; i -= countFriends + 1)
        {
            result += numbers[i];
        }

        return result;
    }

    static int FirstTask(List<int> numbers)
    {
        int maxNum = -1;
        int bestPlayer = -1;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 21)
            {
                continue;
            }

            if (numbers[i] > maxNum)
            {
                maxNum = numbers[i];
                bestPlayer = i;
            }
            else if (numbers[i] == maxNum)
            {
                bestPlayer = -1;
            }
        }

        return bestPlayer;
    }
}
