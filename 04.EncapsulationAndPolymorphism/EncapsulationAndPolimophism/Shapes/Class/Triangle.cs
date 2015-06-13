using System;

namespace Shapes.Class
{
    class Triangle : BasicShape
    {
        private double a;
        private double b;
        private double c;
        private double h;
        
        public Triangle(double a, double b, double c, double h)
        {
            this.A = a;
            this.B = b;
            this.H = h;
            this.C = c;
        }

        public double A
        {
            get { return this.a; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("hypotenuse", "Hypotenuse cannot be negative length!");
                this.a = value;
            }
        }
        public double B
        {
            get { return this.b; }
            set
            {
                if (value < 0)
                    throw    new ArgumentOutOfRangeException("cathetus", "Cathetus cannot be negative length!");
                this.b = value;
            }
        }
        public double C
        {
            get { return this.c; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("cathetus", "Cathetus cannot be negative length!");
                if (this.A >= (this.B + value))
                    throw new ArithmeticException("This triangle is impossible!");
                this.c = value;
            }
        }
        public double H
        {
            get { return this.h; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("height", "Height cannot be negative!");
                this.h = value;
            }
        }

        public override double CalculateArea()
        {
            return (this.A * this.B) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.A + this.B + this.C;
        }
    }
}
