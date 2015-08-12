using System;


class OneTaskIsNotEnough
{
    static void Main()
    {
        int lampCount = int.Parse(Console.ReadLine());
        string commands1 = Console.ReadLine();
        string commands2 = Console.ReadLine();

        int lastLamp = LampsTask(lampCount);
        Console.WriteLine(lastLamp);

        Task2(commands1);
        Task2(commands2);      
    }

    private static void Task2(string commands1)
    {
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };

        int x = 0;
        int y = 0;
        int orientation = 0;

        for (int i = 0; i < 4; i++)
        {
            foreach(var symbol in commands1)
            {
                if(symbol == 'S')
                {
                    x += dx[orientation];
                    y += dy[orientation];
                }
                else if (symbol == 'L')
                {
                    orientation -= 1;
                    orientation += 4;
                    orientation %= 4;
                }
                else if (symbol == 'R')
                {
                    orientation += 1;
                    orientation %= 4;
                }
            }
        }

        if (x == 0 && y == 0)
        {
            Console.WriteLine("bounded");
        }
        else
        {
            Console.WriteLine("unbounded");
        }

    }

    private static int LampsTask(int lampCount)
    {
        var turnOnNow = new bool[lampCount + 1];
        var lamps = new int[lampCount + 1];

        for (int i = 1; i < lamps.Length; i++)
        {
            lamps[i] = i;
        }

        int lastLamp = 0;
        int jump = 1;

        while (lampCount > 0)
        {
            jump++;

            Array.Clear(turnOnNow, 1, lampCount);

            for (int i = 1; i <= lampCount; i += jump)
            {
                turnOnNow[i] = true;
            }

            int newCountOff = 0;
            for (int i = 1; i <= lampCount; i++)
            {
                if (!turnOnNow[i])
                {
                    newCountOff++;
                    lamps[newCountOff] = lamps[i];
                    lastLamp = lamps[i];
                }
            }

            lampCount = newCountOff;
        }

        return lastLamp;
    }
}
