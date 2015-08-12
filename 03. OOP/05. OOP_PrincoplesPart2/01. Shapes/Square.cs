namespace _01.Shapes
{
    using System;

    public class Square : Shape
    {
        private decimal height;

        public Square(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override decimal Width { get; set; }
        public override decimal Height 
        { 
            get
            {
                return this.height;
            }
            set
            {
                if (value != this.Width)
                {
                    throw new ArgumentException("Height must be equal to WIDTH!");
                }
                this.height = value;
            }
        }

        public override decimal CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
