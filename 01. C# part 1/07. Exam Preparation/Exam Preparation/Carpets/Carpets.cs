using System;

class Carpets
{
    static void Main()
    {
        int len = int.Parse(Console.ReadLine());
        int center = (len / 2) - 1;
        int checkCenter = len / 2;

        if (checkCenter % 2 == 0)
        {
            for (int row = 0; row <= center; row++)
            {
                for (int col = 0; col < len; col++)
                {
                    if (col >= center - row && col <= center + row + 1)
                    {
                        if (col <= center)
                        {
                            if ((col % 2 == 0 && row % 2 == 0) || (col % 2 == 1 && row % 2 == 1))
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("/");
                            }
                        }
                        else
                        {
                            if ((col % 2 == 1 && row % 2 == 0) || (col % 2 == 0 && row % 2 == 1))
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("\\");
                            }
                        }

                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int row = 0; row <= center; row++)
            {
                for (int col = 0; col < len; col++)
                {
                    if (col >= center - row && col <= center + row + 1)
                    {
                        if (col <= center)
                        {
                            if ((col % 2 == 1 && row % 2 == 0) || (col % 2 == 0 && row % 2 == 1))
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("/");
                            }
                        }
                        else
                        {
                            if ((col % 2 == 1 && row % 2 == 1) || (col % 2 == 0 && row % 2 == 0))
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("\\");
                            }
                        }

                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }




        for (int row = len - 1; row > center; row--)
        {
            for (int col = len - 1; col >= 0; col--)
            {
                if (col <= row && col >= len - row - 1)
                {
                    if (col <= center)
                    {
                        if ((col % 2 == 1 && row % 2 == 1) || (col % 2 == 0 && row % 2 == 0))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("/");
                        }    
                    }
                    else
                    {
                        if ((col % 2 == 1 && row % 2 == 0) || (col % 2 == 0 && row % 2 == 1))
                        {
                            Console.Write(" ");
                        }
                        else
                        { 
                            Console.Write("\\");
                        }
                    }

                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
