namespace Shapes.Class
{
    class Rectangle : BasicShape
    {
        public Rectangle(double a, double b)
        {
            this.Width = a;
            this.Height = b;
        }

        public override double CalculateArea()
        {
            return this.Width*this.Height;
        }

        public override double CalculatePerimeter()
        {
            return (this.Width*2) + (this.Height*2);
        }
    }
}
