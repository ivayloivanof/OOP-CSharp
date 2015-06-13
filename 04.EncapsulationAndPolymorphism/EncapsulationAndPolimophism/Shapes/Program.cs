namespace Shapes
{
    using System;
    using Interfaces;
    using Shapes.Class;

    public class Program
    {
        public static void Main()
        {
            IShape[] shapes = new IShape[3];

            // We produce figures of he basics of matryoshka dolls
            shapes[0] = new Circle(4);
            shapes[1] = new Triangle(5, 1.4, 2.4, 8.5);
            shapes[2] = new Rectangle(8, 5);

            foreach (IShape shape in shapes)
            {
                Console.WriteLine("area is: {0}", shape.CalculateArea());
                Console.WriteLine("perimeter is: {0}", shape.CalculatePerimeter());
            }
        }
    }
}
