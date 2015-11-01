using System;

class CheckPointInCircleOutRectangle
{
    static void Main()
    {
        /*
         Problem 10. Point Inside a Circle & Outside of a Rectangle
            Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
            R(top=1, left=-1, width=6, height=2).
         */
        Console.WriteLine("Check if given point (x,y) is within circle K((1,1), 1.5) and out of rectangle");
        Console.Write("Insert x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Insert y: ");
        double y = double.Parse(Console.ReadLine());

        bool checkPoint = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5)) && (!(((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1))));

        Console.WriteLine("Is the point ({0},{1}) within a circle K((1,1), 1.5)and out of rectangle?\nIt's {2}.", x, y, checkPoint);
    }
}
