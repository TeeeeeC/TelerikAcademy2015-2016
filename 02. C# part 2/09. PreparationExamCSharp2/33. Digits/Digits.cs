using System;
using System.Collections.Generic;
using System.Text;

class Digits
{
    static int[,] matrix;

    static void Main()
    {
        Input();
        var result = FindSum();
        Console.WriteLine(result);
    }

    private static long FindSum()
    {
        long result = 0;
        for (int row = 0; row < matrix.GetLength(0) - 4; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int digit = FindDigit(row, col);
                result += digit;
            }
        }
        return result;
    }

    private static int FindDigit(int row, int col)
    {
        if (matrix[row, col + 2] == 1 && matrix[row + 1, col + 2] == 1 && matrix[row + 2, col + 2] == 1 
            && matrix[row + 3, col + 2] == 1 && matrix[row + 4, col + 2] == 1 
            && matrix[row + 1, col + 1] == 1 && matrix[row + 2, col] == 1)
        {
            return 1;
        }
        else if (matrix[row, col + 1] == 2 && matrix[row + 1, col] == 2 && matrix[row + 1, col + 2] == 2
            && matrix[row + 2, col + 2] == 2 && matrix[row + 3, col + 1] == 2 && matrix[row + 4, col] == 2
            && matrix[row + 4, col + 1] == 2 && matrix[row + 4, col + 2] == 2)
        {
            return 2;
        }
        else if (matrix[row, col] == 3 && matrix[row, col + 1] == 3 && matrix[row, col + 2] == 3
            && matrix[row + 1, col + 2] == 3 && matrix[row + 2, col + 1] == 3 && matrix[row + 2, col + 2] == 3
            && matrix[row + 3, col + 2] == 3 && matrix[row + 4, col] == 3 && matrix[row + 4, col + 1] == 3
            && matrix[row + 4, col + 2] == 3)
        {
            return 3;
        }
        else if (matrix[row, col] == 4 && matrix[row + 1, col] == 4 && matrix[row + 2, col] == 4 
            && matrix[row + 2, col + 1] == 4 && matrix[row, col + 2] == 4 && matrix[row + 1, col + 2] == 4
            && matrix[row + 2, col + 2] == 4 && matrix[row + 3, col + 2] == 4 && matrix[row + 4, col + 2] == 4)
        {
            return 4;
        }
        else if (matrix[row, col] == 5 && matrix[row, col + 1] == 5 && matrix[row, col + 2] == 5 
            && matrix[row + 1, col] == 5 && matrix[row + 2, col] == 5 && matrix[row + 2, col + 1] == 5 
            && matrix[row + 2, col + 2] == 5 && matrix[row + 3, col + 2] == 5
            && matrix[row + 4, col] == 5 && matrix[row + 4, col + 1] == 5 && matrix[row + 4, col + 2] == 5)
        {
            return 5;
        }
        else if (matrix[row, col] == 6 && matrix[row, col + 1] == 6 && matrix[row, col + 2] == 6
            && matrix[row + 4, col] == 6 && matrix[row + 4, col + 1] == 6 && matrix[row + 4, col + 2] == 6
            && matrix[row + 1, col] == 6 && matrix[row + 2, col] == 6 && matrix[row + 3, col] == 6
            && matrix[row + 2, col + 1] == 6 && matrix[row + 2, col + 2] == 6 && matrix[row + 3, col + 2] == 6)
        {
            return 6;
        }
        else if (matrix[row, col] == 7 && matrix[row, col + 1] == 7 && matrix[row, col + 2] == 7
            && matrix[row + 1, col + 2] == 7 && matrix[row + 2, col + 1] == 7
            && matrix[row + 3, col + 1] == 7 && matrix[row + 4, col + 1] == 7)
        {
            return 7;
        }
        else if (matrix[row, col] == 8 && matrix[row, col + 1] == 8 && matrix[row, col + 2] == 8
            && matrix[row + 4, col] == 8 && matrix[row + 4, col + 1] == 8 && matrix[row + 4, col + 2] == 8
            && matrix[row + 1, col] == 8 && matrix[row + 1, col + 2] == 8 && matrix[row + 2, col + 1] == 8
            && matrix[row + 3, col] == 8 && matrix[row + 3, col + 2] == 8)
        {
            return 8;
        }
        else if (matrix[row, col] == 9 && matrix[row, col + 1] == 9 && matrix[row, col + 2] == 9
            && matrix[row + 1, col + 2] == 9 && matrix[row + 2, col + 2] == 9 && matrix[row + 3, col + 2] == 9 && matrix[row + 4, col + 2] == 9
            && matrix[row + 1, col] == 9 && matrix[row + 2, col + 1] == 9 && matrix[row + 4, col] == 9 && matrix[row + 4, col + 1] == 9)
        {
            return 9;
        }

        return 0;
    }

    private static void Input()
    {
        int number = int.Parse(Console.ReadLine());
        matrix = new int[number, number];

        for (int row = 0; row < number; row++)
        {
            string[] nums = Console.ReadLine().Split(' ');
            for (int col = 0; col < nums.Length; col++)
            {
                matrix[row, col] = int.Parse(nums[col]);
            }
        }
    }
}
