using System;
using System.Collections.Generic;

class KukataIsDancing
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];

        var commands = new List<string>();
        int rows = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            commands.Add(Console.ReadLine());
        }

        int row = 1, col = 1;
        string direction = "left";
        string oldDirection = "up";
        char oldComand = 'R';

        foreach(var command in commands)
        {
            int indexFirstRight = command.IndexOf("R", 0);
            int indexFirstLeft = command.IndexOf("L", 0);

            if (indexFirstRight < indexFirstLeft)
            {
                oldComand = 'L';
            }

            for (int i = 0; i < command.Length; i++)
            {
                switch(command[i])
                {
                    case 'W': 
                        if(direction == "up")
                        {
                            if(row > 0 )
                            {
                                row--;
                            }
                            else
                            {
                                row = 2;
                            }
                        }
                        else if (direction == "down")
                        {
                            if (row < 2)
                            {
                                row++;
                            }
                            else
                            {
                                row = 0;
                            }
                        }
                        else if (direction == "right")
                        {
                            if (col < 2)
                            {
                                col++;
                            }
                            else
                            {
                                col = 0;
                            }
                        }
                        else if (direction == "left")
                        {
                            if (col > 0)
                            {
                                col--;
                            }
                            else
                            {
                                col = 2;
                            }
                        }
                        break;
                    case 'L':
                        if(oldComand != 'L')
                        {
                            if (direction == "left")
                            {
                                oldDirection = "up";
                            }
                            else if (direction == "down")
                            {
                                oldDirection = "left";
                            }
                            else if (direction == "right")
                            {
                                oldDirection = "down";
                            }
                            else if (direction == "up")
                            {
                                oldDirection = "right";
                            }
                        }

                        if(direction == "left" && oldDirection == "up")
                        {
                            oldDirection = "left";
                            direction = "down";
                        }
                        else if (direction == "down" && oldDirection == "left")
                        {
                            oldDirection = "down";
                            direction = "right";
                        }
                        else if (direction == "right" && oldDirection == "down")
                        {
                            oldDirection = "right";
                            direction = "up";
                        }
                        else if (direction == "up" && oldDirection == "right")
                        {
                            oldDirection = "up";
                            direction = "left";
                        }
                        oldComand = command[i];
                        break;
                    case 'R':
                        if (oldComand != 'R')
                        {
                            if (direction == "left")
                            {
                                oldDirection = "down";
                            }
                            else if (direction == "up")
                            {
                                oldDirection = "left";
                            }
                            else if (direction == "right")
                            {
                                oldDirection = "up";
                            }
                            else if (direction == "down")
                            {
                                oldDirection = "right";
                            }
                        }

                        if (direction == "left" && oldDirection == "down")
                        {
                            oldDirection = "left";
                            direction = "up";
                        }
                        else if (direction == "up" && oldDirection == "left")
                        {
                            oldDirection = "up";
                            direction = "right";
                        }
                        else if (direction == "right" && oldDirection == "up")
                        {
                            oldDirection = "right";
                            direction = "down";
                        }
                        else if (direction == "down" && oldDirection == "right")
                        {
                            oldDirection = "down";
                            direction = "left";
                        }
                        oldComand = command[i];
                        break;
                }
            }

            if(row == 1 && col == 1)
            {
                Console.WriteLine("GREEN");
            }
            else if ((row == 0 && col == 0) || (row == 0 && col == 2) || (row == 2 && col == 0) || (row == 2 && col == 2))
            {
                Console.WriteLine("RED");
            }
            else
            {
                Console.WriteLine("BLUE");
            }

            row = 1;
            col = 1;
        }
    }
}
