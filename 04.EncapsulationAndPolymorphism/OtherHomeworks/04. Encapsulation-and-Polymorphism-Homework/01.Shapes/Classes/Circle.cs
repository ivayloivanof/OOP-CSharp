using System;

namespace Shapes.Models
{
    class Circle : BasicShape
    {
        public Circle(double radius)
            : base(radius, 1)
        {
        }

        public override double Area()
        {
            double area = Math.PI * this.Width * this.Width;

            return area;
        }

        public override double Perimeter()
        {
            double perimeter = Math.PI * this.Width * 2;

            return perimeter;
        }
    }
}
