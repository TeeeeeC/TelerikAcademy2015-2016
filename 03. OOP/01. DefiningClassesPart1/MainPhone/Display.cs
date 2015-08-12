namespace GSMTest
{
    using System;

    public class Display 
    {
        private const int InitialNumber = 0;

        private int width;
        private int heigth;
        private int depth;
        private long numberOfColors;

        public Display()
        {
            this.Width = InitialNumber;
            this.Heigth = InitialNumber;
            this.Depth = InitialNumber;
            this.NumberOfColors = InitialNumber;
        }

        public Display(int displayWidth, int displayHeigth, int displayDepth, long displayNumberOfColors)
        {
            this.Width = displayWidth;
            this.Heigth = displayHeigth;
            this.Depth = displayDepth;
            this.NumberOfColors = displayNumberOfColors;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid number!");
                }
                this.width = value;
            }
        }

        public int Heigth
        {
            get
            {
                return this.heigth;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Negative number!");
                }

                this.heigth = value;
            }
        }

        public int Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Negative number!");
                }

                this.depth = value;
            }
        }

        public long NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid number!");
                }
                this.numberOfColors = value;
            }
        }

        
    }
}
