using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

struct Rocks
{
    public int x;
    public int y;
    public char symbol;
    public string str;
    public ConsoleColor color;
}
class FallingRocks
{
    static char[] symbols = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
    static string dwarfSigns = "(0)";
    static int playField = 25;
    static int lives = 5;
    static int score = 0;

    static void PrintAtPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintAtPositionRocks(int x, int y, char c, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void Main()
    {
        Console.BufferWidth = Console.WindowWidth = 50;
        Console.BufferHeight = Console.WindowHeight = 35;

        Rocks dwarf = new Rocks();
        dwarf.x = playField / 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.str = dwarfSigns;
        dwarf.color = ConsoleColor.White;

        Random randomGenerator = new Random();
        List<Rocks> rocks = new List<Rocks>();

        while (true)
        {
            bool hitted = false;

            Rocks newRocks = new Rocks();

            newRocks.color = ConsoleColor.White;
            newRocks.x = randomGenerator.Next(0, playField + 3);
            newRocks.y = 0;
            newRocks.symbol = symbols[randomGenerator.Next(0, 12)];
            rocks.Add(newRocks);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x > 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }

                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x < playField)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            List<Rocks> newList = new List<Rocks>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rocks oldRocks = rocks[i];
                Rocks updateRocks = new Rocks();
                updateRocks.x = oldRocks.x;
                updateRocks.y = oldRocks.y + 1;
                updateRocks.symbol = oldRocks.symbol;
                updateRocks.color = oldRocks.color;

                if ((updateRocks.y == dwarf.y && updateRocks.x == dwarf.x) ||
                    (updateRocks.y == dwarf.y && updateRocks.x == dwarf.x + 1) ||
                    (updateRocks.y == dwarf.y && updateRocks.x == dwarf.x + 2))
                {
                    lives--;
                    hitted = true;

                    if (updateRocks.y == dwarf.y && updateRocks.x == dwarf.x)
                    {
                        PrintAtPosition(updateRocks.x, updateRocks.y, "X", ConsoleColor.Red);
                        Thread.Sleep(500);
                    }

                    if (updateRocks.y == dwarf.y && updateRocks.x == dwarf.x + 1)
                    {
                        PrintAtPosition(updateRocks.x, updateRocks.y, "X", ConsoleColor.Red);
                        Thread.Sleep(500);
                    }

                    if (updateRocks.y == dwarf.y && updateRocks.x == dwarf.x + 2)
                    {
                        PrintAtPosition(updateRocks.x, updateRocks.y, "X", ConsoleColor.Red);
                        Thread.Sleep(500);
                    }

                    if (lives <= 0)
                    {
                        PrintAtPosition(12, 15, "GAME OVER!", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                }
                else
                {
                    if (updateRocks.y == Console.WindowHeight - 1)
                    {
                        score++;
                    }
                }
                if (updateRocks.y < Console.WindowHeight - 1)
                {
                    newList.Add(updateRocks);
                }

            }

            rocks = newList;
            Console.Clear();

            if (hitted)
            {
                rocks.Clear();
            }
            else
            {
                PrintAtPosition(dwarf.x, dwarf.y, dwarf.str, dwarf.color);
            }

            foreach (Rocks printRocks in rocks)
            {
                PrintAtPositionRocks(printRocks.x, printRocks.y, printRocks.symbol, printRocks.color);
            }

            PrintAtPosition(35, 7, "Lives: " + lives, ConsoleColor.Red);
            PrintAtPosition(35, 8, "Score: " + score, ConsoleColor.Red);
            Thread.Sleep(150);
        }
    }


}