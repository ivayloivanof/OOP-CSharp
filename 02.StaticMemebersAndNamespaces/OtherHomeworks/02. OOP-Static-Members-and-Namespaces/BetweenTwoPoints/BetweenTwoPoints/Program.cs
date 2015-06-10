using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoPoints
{
    class DistanceCalculator
    {
        public static double FindDistance(Point firstPoint, Point secondPoint)
        {
            double something = (secondPoint.X - firstPoint.X)*(secondPoint.X - firstPoint.X);
            double something2 = (secondPoint.Y - firstPoint.Y)*(secondPoint.Y - firstPoint.Y);
            double something3 = (secondPoint.Z - firstPoint.Z)*(secondPoint.Z - firstPoint.Z);
            double result = Math.Sqrt((something+something2+something3));
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point somepoint = new Point(1,1,1);
            Point somepoint2 = new Point(5, 4, 7);
            Console.WriteLine(DistanceCalculator.FindDistance(somepoint,somepoint2));
        }
    }
}
