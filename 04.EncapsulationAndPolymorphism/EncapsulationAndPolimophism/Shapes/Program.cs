using System;
using Shapes.Class;

namespace Shapes
{
    using Interfaces;
    class Program
    {
        static void Main()
        {
            IShape circle = new Circle(4);
            Console.WriteLine(circle.CalculateArea());
            circle.CalculatePerimeter();
            IShape triangle = new Triangle(5, 8.4, 6.4, 8.5);
            triangle.CalculateArea();
            triangle.CalculatePerimeter();
            IShape rectangle = new Rectangle(8, 5);
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();
            Console.WriteLine();
        }
    }
}
