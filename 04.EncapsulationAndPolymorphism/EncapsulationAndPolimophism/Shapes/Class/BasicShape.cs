using System;

namespace Shapes.Class
{
    using Interfaces;

    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("width", "Width cannot be negative length!");
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("height", "Height cannot be negative length!");
                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
