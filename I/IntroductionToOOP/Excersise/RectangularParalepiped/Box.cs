using System;
using System.Collections.Generic;
using System.Text;

namespace RectangularParallelepiped
{
    class Box
    {
        private double lenght;

        public double Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Box (double lenght,double width,double height)
        {
            this.Width = width;
            this.Lenght = lenght;
            this.Height = height;
        }

        public double SurfaceArea(double lenght,double width,double height)
        {
            return 2 * this.lenght * this.height + 2 * this.height * this.width + 2 * this.lenght * this.width;
        }
        public double LateralSurfaceArea(double lenght, double width, double height)
        {
            return 2 * this.lenght * this.height + 2 * this.width * this.height;
        }
        public double Volume(double lenght, double width, double height)
        {
            return this.lenght * this.height * this.width;
        }

    }
}
