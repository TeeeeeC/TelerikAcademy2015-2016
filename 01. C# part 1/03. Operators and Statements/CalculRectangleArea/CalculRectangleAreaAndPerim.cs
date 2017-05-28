﻿using System;

class CalculRectangleAreaAndPerim
{
    static void Main()
    {
        /*
         Problem 4. Rectangles
            Write an expression that calculates rectangle’s perimeter and area by given width and height.
         */
        Console.Write("Insert width: "); 
        double width = double.Parse(Console.ReadLine());
        Console.Write("Insert height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        double area = width * height;

        Console.WriteLine("Rectangle's perimeter is {0}.", perimeter);
        Console.WriteLine("Rectangle's area is {0}.", area);
    }
}
