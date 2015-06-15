namespace Shapes.Models
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double Area()
        {
            double area = this.Width * this.Height;

            return area;
        }

        public override double Perimeter()
        {
            double perimeter = (this.Width * 2) + (this.Height * 2);

            return perimeter;
        }
    }
}
