namespace _2.DefiningClassesPart2
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D initialPoint = default(Point3D);

        private int x;
        private int y;
        private int z;

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("X must be positive or zero!");
                }
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Y must be positive or zero!");
                }
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Z must be positive or zero!");
                }
                this.z = value;
            }
        }

        public static Point3D InitialPoint
        {
            get
            {
                return initialPoint;
            }
        }

        public override string ToString()
        {
            return "{" + this.X + "," + this.Y + "," + this.Z + "}";
        }
    }
}
