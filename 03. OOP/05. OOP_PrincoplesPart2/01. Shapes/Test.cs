namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            Shape[] arr = 
            {
                new Square(6,6),
                new Rectangle(5,6),
                new Triangle(5,6)
            };

            foreach (Shape anyShape in arr)
            {
                Console.WriteLine("Shape - {0} Surface = {1}mm", anyShape.GetType().Name.PadRight(10, ' '), anyShape.CalculateSurface());
            }
        }
    }
}
