﻿namespace Abstraction
{
    using System;

    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius 
        { 
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The radius must be positive number!");
                }

                this.radius = value;
            }
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
