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
            Console.WriteLine("circle area: " + circle.CalculateArea());
            Console.WriteLine("circle perimeter: " + circle.CalculatePerimeter());
            IShape triangle = new Triangle(5, 8.4, 6.4, 8.5);
            Console.WriteLine("triangle area: " + triangle.CalculateArea());
            Console.WriteLine("triangle perimeter: " + triangle.CalculatePerimeter());
            IShape rectangle = new Rectangle(8, 5);
            Console.WriteLine("rectangle area: " + rectangle.CalculateArea());
            Console.WriteLine("rectangle perimeter: " + rectangle.CalculatePerimeter());
            Console.WriteLine();
        }
    }
}
