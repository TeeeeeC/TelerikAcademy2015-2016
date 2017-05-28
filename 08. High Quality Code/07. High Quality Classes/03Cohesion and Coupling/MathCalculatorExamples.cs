namespace CohesionAndCoupling
{
    using System;

    public class MathCalculatorExamples
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(File.GetExtension("example"));
            Console.WriteLine(File.GetExtension("example.pdf"));
            Console.WriteLine(File.GetExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileName("example"));
            Console.WriteLine(File.GetFileName("example.pdf"));
            Console.WriteLine(File.GetFileName("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", MathCalculator.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", MathCalculator.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", MathCalculator.CalculateVolume(3, 4, 5));
            Console.WriteLine("Diagonal XYZ = {0:f2}", MathCalculator.CalculateDistance3D(0, 0, 0, 3, 4, 5));
            Console.WriteLine("Diagonal XY = {0:f2}", MathCalculator.CalculateDistance2D(0, 0, 3, 4));
            Console.WriteLine("Diagonal XZ = {0:f2}", MathCalculator.CalculateDistance2D(0, 0, 4, 5));
            Console.WriteLine("Diagonal YZ = {0:f2}", MathCalculator.CalculateDistance2D(0, 0, 2, 3));
        }
    }
}
