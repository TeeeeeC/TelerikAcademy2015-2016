namespace _01.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override decimal Width { get; set; }
        public override decimal Height { get; set; }

        public override decimal CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
