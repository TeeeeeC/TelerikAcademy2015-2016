using System;

class PrintPerimAreaCircle
{
    static void Main()
    {
        /*
         Problem 3. Circle Perimeter and Area
            Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
         */
        Console.Write("Insert the radius of a circle: ");
        float r = float.Parse(Console.ReadLine());
        float pi = (float) Math.PI;
        float perimeter = 2 * pi * r;
        float area = pi * r * r;

        Console.WriteLine("Perimeter is {0} and area is {1}!", perimeter, area);
    }
}

