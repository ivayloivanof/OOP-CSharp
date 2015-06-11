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
            set { this.r = value; }
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
