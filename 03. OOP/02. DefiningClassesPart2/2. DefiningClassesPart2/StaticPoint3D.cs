namespace _2.DefiningClassesPart2
{
    using System;

    public static class StaticPoint3D 
    {
        public static decimal CalculateDistance(Point3D point1, Point3D point2)
        {
            return (decimal)Math.Sqrt(Math.Pow(point1.X - point2.X, 2) +
                Math.Pow(point1.Y - point2.Y, 2) + Math.Pow(point1.Z - point2.Z, 2));
        }
    }
}
