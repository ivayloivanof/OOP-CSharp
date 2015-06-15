using System;

namespace Shapes.Models
{
    class Triangle : BasicShape
    {
        private double side;

        public Triangle(double firstSide, double secondSide, double thirdSide) 
            : base(firstSide, secondSide)
        {
            this.Side = thirdSide;
        }

        public double Side
        {
            get
            {
                return this.side;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("side", "The side cannot be a negative number!");
                }

                this.side = value;
            }
        }

        public override double Area()
        {
            double p = (this.Width + this.Height + this.side) / 2;
            double area = Math.Sqrt(p * (p - this.Height) * (p - this.Width) * (p - this.side));

            if (double.IsNaN(area))
            {
                throw new ArgumentException("Not a Triangle if one side is bigger than the other two combined");
            }

            return area;
        }

        public override double Perimeter()
        {
            double perimeter = this.Width + this.Height + this.side;

            return perimeter;
        }
    }
}
