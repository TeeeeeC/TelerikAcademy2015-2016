namespace Refactoring
{
    using System;

    public class MatrixMain
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            var number = int.Parse(Console.ReadLine());

            var matrix = new Matrix(number);
            matrix.Print();
        }
    }
}
