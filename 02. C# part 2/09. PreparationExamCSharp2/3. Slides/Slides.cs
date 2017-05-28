using System;

class Slides
{
    static void Main()
    {
        string[] inputSizeOf3Darr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        int width = int.Parse(inputSizeOf3Darr[0]);
        int height = int.Parse(inputSizeOf3Darr[1]);
        int depth = int.Parse(inputSizeOf3Darr[2]);

        string[,,] cube = new string[height, depth, width];

        for (int h = 0; h < height; h++)
        {
            string[] linesOfDepth = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            for (int d = 0; d < depth; d++)
            {
                string[] linesWidth = linesOfDepth[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < width; w++)
                {
                    cube[h, d, w] = linesWidth[w];
                }
            }
        }

        string[] inputBallCoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int ballWidth = int.Parse(inputBallCoordinates[0]);
        int ballDepth = int.Parse(inputBallCoordinates[1]);
        int ballHeight = 0;
        bool isBasket = false;

        while(true)
        {
            string[] command = cube[ballHeight, ballDepth, ballWidth].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int oldballHeight = ballHeight;
            int oldballDepth = ballDepth;
            int oldballWidth = ballWidth;

            if (isBasket || command[0] == "B")
            {
                Console.WriteLine("No\n{0} {1} {2}", ballWidth, ballHeight, ballDepth);
                break;
            }

            if (ballHeight == height - 1)
            {
                Console.WriteLine("Yes\n{0} {1} {2}", ballWidth, ballHeight, ballDepth);
                break;
            }

            switch(command[0])
            {
                case "S": 
                    switch(command[1])
                    {
                        case "L": ballWidth--;
                            break;
                        case "R": ballWidth++;
                            break;
                        case "F": ballDepth--;
                            break;
                        case "B": ballDepth++;
                            break;
                        case "FL":
                            ballDepth--;
                            ballWidth--;
                            break;
                        case "FR":
                            ballDepth--;
                            ballWidth++;
                            break;
                        case "BL":
                            ballDepth++;
                            ballWidth--;
                            break;
                        case "BR":
                            ballDepth++;
                            ballWidth++;
                            break;
                        default: throw new ArgumentException("Invalid command!");
                    }
                    ballHeight++;
                    break;
                case "T":
                    ballWidth = int.Parse(command[1]);
                    ballDepth = int.Parse(command[2]);
                    break;
                case "E":
                    ballHeight++;
                    break;
                case "B":
                    isBasket = true;
                    break;
                default: throw new ArgumentException("Invalid command!"); 
            }

            if ((ballWidth < 0 || ballWidth > width - 1) || (ballDepth < 0 || ballDepth > depth - 1))
            {
                Console.WriteLine("No\n{0} {1} {2}", oldballWidth, oldballHeight, oldballDepth);
                break;
            }
        }
    }
}
