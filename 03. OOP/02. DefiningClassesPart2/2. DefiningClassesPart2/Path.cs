namespace _2.DefiningClassesPart2
{
    public class Path
    {
        private Point3D point;

        public Path()
        {
            this.Point = point;
        }

        public Path(Point3D point)
        {
            this.Point = point;
        }

        public Point3D Point
        {
            get
            {
                return this.point;
            }
            set 
            {
                this.point = value;
            }
        }

        public override string ToString()
        {
            return this.Point.ToString();
        }
    }
}
