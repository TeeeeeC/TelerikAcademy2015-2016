using System;
using System.Text;

class Laser
{
    static void Main()
    {
        string[] sizeOf3DArr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        int width = int.Parse(sizeOf3DArr[0]);
        int height = int.Parse(sizeOf3DArr[1]);
        int depth = int.Parse(sizeOf3DArr[2]);

        var cube = new int[height, depth, width];

        string[] startLaserCoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int startW = int.Parse(startLaserCoordinates[0]);
        int startH = int.Parse(startLaserCoordinates[1]);
        int startD = int.Parse(startLaserCoordinates[2]);
        int firstStartW = startW;
        int firstStartH = startH;
        int firstStartD = startD;

        string[] directions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int dirW = int.Parse(directions[0]);
        int dirH = int.Parse(directions[1]);
        int dirD = int.Parse(directions[2]);

        var burnedPath = new bool[height + 1, depth + 1, width + 1];

        burnedPath[startH, startD, startW] = true;

        while(true)
        {
            int lastCoordinatesW = startW;
            int lastCoordinatesH = startH;
            int lastCoordinatesD = startD;

            switch(dirH)
            {
                case 0:
                    switch (dirD)
                    {
                        case 0:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            break;
                        case 1:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            startD++;
                            break;
                        case -1:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            startD--;
                            break;
                    }
                    break;
                case 1:
                    switch (dirD)
                    {
                        case 0:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            break;
                        case 1:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            startD++;
                            break;
                        case -1:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            startD--;
                            break;
                    }
                    startH++;
                    break;
                case -1:
                    switch (dirD)
                    {
                        case 0:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            break;
                        case 1:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            startD++;
                            break;
                        case -1:
                            switch (dirW)
                            {
                                case 0:
                                    break;
                                case 1:
                                    startW++;
                                    break;
                                case -1:
                                    startW--;
                                    break;
                            }
                            startD--;
                            break;
                    }
                    startH--;
                    break;
            }

            if (isEdges(startH, startD, startW, height, depth, width) || (startH == firstStartH && startD == firstStartD && startW == firstStartW) || burnedPath[startH, startD, startW])
            {
                Console.WriteLine("{0} {1} {2}", lastCoordinatesW, lastCoordinatesH, lastCoordinatesD);
                break;
            }
            else
            {
                if ((startH == 1 || startH == height) || (startD == 1 || startD == depth) || (startW == 1 || startW == width))
                {
                    if (startH == 1 || startH == height)
                    {
                        dirH = changeDirection(startH, startD, startW, height, depth, width, dirH, dirD, dirW);
                    }
                    else if (startD == 1 || startD == depth)
                    {
                        dirD = changeDirection(startH, startD, startW, height, depth, width, dirH, dirD, dirW);
                    }
                    else
                    {
                        dirW = changeDirection(startH, startD, startW, height, depth, width, dirH, dirD, dirW);
                    }
                }
            }

            burnedPath[startH, startD, startW] = true;
        }
    }

    private static int changeDirection(int startH, int startD, int startW, int height, int depth, int width, int dirH, int dirD, int dirW)
    {
        if(startH == 1 && dirH != 0)
        {
            dirH = 1;
            return dirH;
        }
        else if(startH == height && dirH != 0)
        {
            dirH = -1;
            return dirH;
        }

        if (startD == 1 && dirD != 0)
        {
            dirD = 1;
            return dirD;
        }
        else if (startD == depth && dirD != 0)
        {
            dirD = -1;
            return dirD;
        }

        if (startW == 1 && dirW != 0)
        {
            dirW = 1;
            return dirW;
        }
        else if (startW == width && dirW != 0)
        {
            dirW = -1;
            return dirW;
        }

        return 0;
    }


    private static bool isEdges(int startH, int startD, int startW, int height, int depth, int width)
    {
        bool isBurnedCube = false;

        if ((startH == 1 && startD == 1) || (startH == 1 && startW == width) || (startH == 1 && startD == depth) || (startH == 1 && startW == 1)
            || (startH == height && startD == 1) || (startH == height && startW == width) || (startH == height && startD == depth) || (startH == height && startW == 1)
            || (startW == 1 && startD == 1) || (startW == width && startD == 1) || (startW == width && startD == depth) || (startW == 1 && startD == depth))
        {
            isBurnedCube = true;
        }

        return isBurnedCube;
    }
}
