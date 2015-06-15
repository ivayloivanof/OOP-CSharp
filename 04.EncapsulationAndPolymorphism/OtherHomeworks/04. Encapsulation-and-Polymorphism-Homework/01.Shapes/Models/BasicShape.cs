namespace Shapes.Models
{
    using System;

    using Shapes.Interface;

    internal abstract class BasicShape : IShape
    {
        private double height;

        private double width;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("width", "The width cannot be a negative number!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("height", "The height cannot be a negative number!");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}