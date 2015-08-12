namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override decimal Width { get; set; }
        public override decimal Height { get; set; }

        public override decimal CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
