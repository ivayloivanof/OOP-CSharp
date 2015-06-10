using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        private static readonly Point StartingPoint = new Point(0, 0, 0);

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point SP
        {
            get { return StartingPoint; }
        }

        public override string ToString()
        {
            string something = "";
            something = "Point 3D coordinates - {" + this.X + "},{" + this.Y + "},{" + this.Z + "};";
            return something;
        }
    }
}
