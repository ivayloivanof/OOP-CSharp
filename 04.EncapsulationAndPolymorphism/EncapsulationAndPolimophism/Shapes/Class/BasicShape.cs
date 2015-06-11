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
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
