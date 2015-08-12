namespace _01.Shapes
{
    public abstract class Shape
    {
        public abstract decimal Width { get; set; }
        public abstract decimal Height { get; set; }

        public abstract decimal CalculateSurface();
    }
}
