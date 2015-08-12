namespace CohesionAndCoupling
{
    using System;

    public static class MathCalculator
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double resultOfExpressionX = (x2 - x1) * (x2 - x1);
            double resultOfExpressionY = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(resultOfExpressionX + resultOfExpressionY);
            return distance;
        }

        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double resultOfExpressionX = (x2 - x1) * (x2 - x1);
            double resultOfExpressionY = (y2 - y1) * (y2 - y1);
            double resultOfExpressionZ = (z2 - z1) * (z2 - z1);
            double distance = Math.Sqrt(resultOfExpressionX + resultOfExpressionY + resultOfExpressionZ);
            return distance;
        }

        public static double CalculateVolume(double width, double height, double depth)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("The width must be positive number!");
            }

            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("The height must be positive number!");
            }

            if (depth <= 0)
            {
                throw new ArgumentOutOfRangeException("The depth must be positive number!");
            }

            double volume = width * height * depth;
            return volume;
        }
    }
}