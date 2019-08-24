using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box
    {
        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0) throw new ArgumentException ("Height cannot be zero or negative. ");
                else height = value;
            }
        }

        private double lenght;

        public double Lenght
        {
            get { return lenght; }
            set
            {
                if (value <= 0) throw new ArgumentException ("Length cannot be zero or negative. ");
                else lenght = value;
            }
        }
        private double width;

        public double Width
        {
            get { return width; }
            set
            {
                if(value<=0) throw new ArgumentException ("Width cannot be zero or negative. ");
                else width = value;
            }
        }
        public Box(double lenght,double width,double height)
        {
            this.Height = height;
            this.Lenght = lenght;
            this.Width = width;
        }
        public double SurfaceArea()
        {
            
            return 2 * (this.Height * this.Width) + 2 * (this.Height * this.Lenght) + 2 * (this.Width * this.Lenght);
        }
        public double LateralSurfaceArea()
        {
            return 2 * (this.Height * this.Width) + 2 * (this.Height * this.Lenght);
        }
        public double Volume()
        {
            return this.Height * this.Width * this.Lenght;
        }

    }
}
