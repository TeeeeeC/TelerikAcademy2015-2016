using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Tron3D
{
    static List<int> passedPathFromRedPLayer = new List<int>();
    static List<List<int>> passedPathFromBluePLayer = new List<List<int>>();
    static List<int> lastCoorRedPlayer = new List<int>();
    static int height, width, depth;
    static int currHeight, currWidth, currDepth;
    static int[, ,] cube;
    static int index = 0;
    static int dir = 0;

    static void Main()
    {
        string[] size = Console.ReadLine().Split(' ');

        height = int.Parse(size[0]) + 1;
        width = int.Parse(size[1]) + 1;
        depth = int.Parse(size[2]) + 1;
        cube = new int[height, width, depth];

        string redPlayer = Console.ReadLine();
        string bluePlayer = Console.ReadLine();

        passedPathFromRedPLayer.Add(height / 2);
        passedPathFromRedPLayer.Add(width / 2);
        passedPathFromRedPLayer.Add(0);
        currHeight = height / 2;
        currWidth = width / 2;
        currDepth = 0;
        lastCoorRedPlayer.Add(currHeight);
        lastCoorRedPlayer.Add(currWidth);
        lastCoorRedPlayer.Add(currDepth);
        //passedPathFromBluePLayer.Add(new List<int>() {height / 2, width / 2, depth});

        bool isWinBluePlayer = false;

        while(true)
        {
            //var lastCoorBluePlayer = passedPathFromBluePLayer[passedPathFromRedPLayer.Count - 1];

           /* foreach(var list in passedPathFromBluePLayer)
            { 
                if(lastCoorRedPlayer == list)
                {
                    if(lastCoorBluePlayer == lastCoorRedPlayer)
                    {
                        Console.WriteLine("DRAW");
                    }
                    else
                    {
                        Console.WriteLine("BLUE");
                    }
                }
            }

            foreach (var list in passedPathFromRedPLayer)
            {
                if (lastCoorBluePlayer == list)
                {
                    if (lastCoorBluePlayer == lastCoorRedPlayer)
                    {
                        Console.WriteLine("DRAW");
                    }
                    else
                    {
                        Console.WriteLine("RED");
                    }
                }
            }*/

            MoveRedPlayer(redPlayer, lastCoorRedPlayer);

            if(index > redPlayer.Length - 1)
            {
                break;
            }
        }
    }

    static void MoveRedPlayer(string redPlayer, List<int> lastCoorRedPlayer)
    {
        char command = redPlayer[index];
        int[,] coordinates = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
        

        switch(command)
        {
            case 'M':
                switch(dir)
                {
                    case 0:
                        if (currWidth > 0 && currWidth < width - 1 && currDepth == 0)
                        {
                            currWidth += 1;
                        }
                        else if (currWidth > 0 && currWidth < width - 1 && depth - 1 == currDepth)
                        {
                            currWidth -= 1;
                        }
                        else if (currDepth >= 0 && currDepth < depth - 1 && width - 1 == currWidth)
                        {
                            currDepth += 1;
                        }
                        else if (currDepth >= 0 && currDepth < depth - 1 && currWidth == 0)
                        {
                            currDepth -= 1;
                        }
                        break;
                    case 1:
                        if (currHeight >= 0 && currHeight < height - 1 && currDepth == 0)
                        {
                            currHeight -= 1;
                        }
                        else if (currHeight >= 0 && currHeight < height - 1 && depth - 1 == currDepth)
                        {
                            currHeight -= 1;
                        }
                        else if (currHeight >= 0 && currHeight < height - 1 && width - 1== currWidth)
                        {
                            currHeight += 1;
                        }
                        else if (currHeight >= 0 && currHeight < depth - 1 && currWidth == 0)
                        {
                            currHeight += 1;
                        }
                        break;
                    case 2:
                        if (currWidth >= 0 && currWidth < width - 1 && currDepth == 0)
                        {
                            currWidth -= 1;
                        }
                        else if (currWidth >= 0 && currWidth < width - 1 && depth - 1 == currDepth)
                        {
                            currWidth += 1;
                        }
                        else if (currDepth >= 0 && currDepth < depth - 1 && width - 1 == currWidth)
                        {
                            currDepth -= 1;
                        }
                        else if (currDepth >= 0 && currDepth < depth - 1 && currWidth == 0)
                        {
                            currDepth += 1;
                        }
                        break;
                    case 3:
                        if (currHeight >= 0 && currHeight < height - 1 && currDepth == 0)
                        {
                            currHeight += 1;
                        }
                        else if (currHeight >= 0 && currHeight < height - 1 && depth - 1 == currDepth)
                        {
                            currHeight += 1;
                        }
                        else if (currHeight >= 0 && currHeight < height - 1 && width - 1 == currWidth)
                        {
                            currHeight += 1;
                        }
                        else if (currHeight >= 0 && currHeight < depth - 1 && currWidth == 0)
                        {
                            currHeight += 1;
                        }
                        break;
                }
                lastCoorRedPlayer.Add(currHeight);
                lastCoorRedPlayer.Add(currWidth);
                lastCoorRedPlayer.Add(currDepth);
                break;
            case 'L':
                if (dir < 3)
                {
                    dir++;
                }
                else
                {
                    dir = 0;
                }
                break;
            case 'R':
                if (dir > 0)
                {
                    dir--;
                }
                else
                {
                    dir = 3;
                }
                break;
        }
        index++;
    }
}
