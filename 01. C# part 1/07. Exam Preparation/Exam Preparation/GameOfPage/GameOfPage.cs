using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

class GameOfPage
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[,] matrix = new int[16, 16];
   
        for (int i = 0; i < 16; i++)
        {
            string binary = Console.ReadLine();

            for (int j = 0; j < 16; j++)
            {
                matrix[i, j] = (int)binary[j] - 48;
            }
        }

        string question = string.Empty;
        List<string> text = new List<string>();
        int countOnes = 0;
        float result = 1.79F;
        int countCookie = 0;

        do
        {
            question = Console.ReadLine();

            if(question == "paypal")
            {
                break;
            }

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if (question == "what is")
            {
                if(matrix[row, col] == 1)
                {
                    if (row != 0 && row != 15 && col != 0 && col != 15)
                    {
                        for (int i = row - 1; i <= row + 1; i++)
                        {
                            for (int j = col - 1; j <= col + 1; j++)
                            {
                                if (matrix[i, j] == 1)
                                {
                                    countOnes++;
                                }
                            }
                        }

                        if (countOnes == 9)
                        {
                            countOnes = 0;
                            text.Add("cookie");
                        }
                        else if (countOnes > 1)
                        {
                            countOnes = 0;
                            text.Add("broken cookie");
                        }
                        else
                        {
                            countOnes = 0;
                            text.Add("cookie crumb");
                        }
                    }
                    else if (row == 0 && col == 0)
                    {
                        if (matrix[row, col + 1] == 1 || matrix[row + 1, col + 1] == 1 || matrix[row + 1, col] == 1)
                        {
                            text.Add("broken cookie");
                        }
                        else
                        {
                            text.Add("cookie crumb");
                        }
                    }
                    else if (row == 0 && col == 15)
                    {
                        if (matrix[row, col - 1] == 1 || matrix[row + 1, col - 1] == 1 || matrix[row + 1, col] == 1)
                        {
                            text.Add("broken cookie");
                        }
                        else
                        {
                            text.Add("cookie crumb");
                        }
                    }
                    else if (row == 15 && col == 0)
                    {
                        if (matrix[row, col + 1] == 1 || matrix[row - 1, col + 1] == 1 || matrix[row - 1, col] == 1)
                        {
                            text.Add("broken cookie");
                        }
                        else
                        {
                            text.Add("cookie crumb");
                        }
                    }
                    else if (row == 15 && col == 15)
                    {
                        if (matrix[row, col - 1] == 1 || matrix[row - 1, col - 1] == 1 || matrix[row - 1, col] == 1)
                        {
                            text.Add("broken cookie");
                        }
                        else
                        {
                            text.Add("cookie crumb");
                        }
                    }
                    else if (row == 0)
                    {
                        if (matrix[row, col - 1] == 1 || matrix[row, col + 1] == 1 || matrix[row + 1, col - 1] == 1
                            || matrix[row + 1, col] == 1 || matrix[row + 1, col + 1] == 1)
                        {
                            text.Add("broken cookie");
                        }
                        else
                        {
                            text.Add("cookie crumb");
                        }
                    }
                    else if (row == 15)
                    {
                        if (matrix[row, col - 1] == 1 || matrix[row, col + 1] == 1 || matrix[row - 1, col - 1] == 1
                            || matrix[row - 1, col] == 1 || matrix[row - 1, col + 1] == 1)
                        {
                            text.Add("broken cookie");
                        }
                        else
                        {
                            text.Add("cookie crumb");
                        }
                    }
                    else if (col == 0)
                    {
                        if (matrix[row - 1, col] == 1 || matrix[row - 1, col + 1] == 1 || matrix[row, col + 1] == 1
                            || matrix[row + 1, col] == 1 || matrix[row + 1, col + 1] == 1)
                        {
                            text.Add("broken cookie");
                        }
                        else
                        {
                            text.Add("cookie crumb");
                        }
                    }
                    else if (col == 15)
                    {
                        if (matrix[row - 1, col] == 1 || matrix[row - 1, col - 1] == 1 || matrix[row, col - 1] == 1
                            || matrix[row + 1, col] == 1 || matrix[row + 1, col - 1] == 1)
                        {
                            text.Add("broken cookie");
                        }
                        else
                        {
                            text.Add("cookie crumb");
                        }
                    }
                }
                else
                {
                    text.Add("smile");
                }
            }
            else 
            {
                if (matrix[row, col] == 1)
                {
                    if (row != 0 && row != 15 && col != 0 && col != 15)
                    {
                        for (int i = row - 1; i <= row + 1; i++)
                        {
                            for (int j = col - 1; j <= col + 1; j++)
                            {
                                if (matrix[i, j] == 1)
                                {
                                    countOnes++;
                                }
                            }
                        }

                        if (countOnes == 9)
                        {
                            countOnes = 0;
                            countCookie++;

                            for (int i = row - 1; i <= row + 1; i++)
                            {
                                for (int j = col - 1; j <= col + 1; j++)
                                {
                                    matrix[i, j] = 0;
                                }
                            }
                        }
                        else
                        {
                            countOnes = 0;
                            text.Add("page");
                        }
                    }
                    else
                    {
                        text.Add("page");
                    }
                }
                else
                {
                    text.Add("smile");
                }
            }
               

        } while(true);

        foreach(string item in text)
        {
            Console.WriteLine(item);
        }

        float finalResult = result * countCookie;
        Console.WriteLine("{0:F2}", finalResult);
    }
}
