using System;

class CheckPointInCircle
{
    static void Main()
    {
        /*
         Problem 7. Point in a Circle
            Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
         */
        Console.WriteLine("Check if given point (x,y) is within K((0,0),2)");
        Console.Write("Insert x: ");
        decimal x = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Insert y: ");
        decimal y = Convert.ToDecimal(Console.ReadLine());

        bool checkPoint = (x * x) + (y * y) <= (2 * 2);

        Console.WriteLine("Is the point ({0},{1}) within a circle K(0,2)?\nIt's {2}.", x, y, checkPoint);
    }
}
