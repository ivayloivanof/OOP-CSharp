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
            this.B = h;
            this.H = h;
            this.C = c;
        }

        public double A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        public double B
        {
            get { return this.b; }
            set { this.b = value; }
        }
        public double C
        {
            get { return this.c; }
            set { this.c = value; }
        }
        public double H
        {
            get { return this.h; }
            set { this.h = value; }
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
