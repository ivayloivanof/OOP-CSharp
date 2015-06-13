using System;

namespace Shapes.Class
{
    using Interfaces;
    class Circle : IShape
    {
        private double r;

        public Circle(double r)
        {
            this.R = r;
        }

        public double R
        {
            get { return this.r; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("radius", "Radius cannot be negative length!");
                this.r = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI*this.R*this.R;
        }

        public double CalculatePerimeter()
        {
            return Math.PI*(this.R*2);
        }
    }
}
