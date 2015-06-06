using System;
namespace Point3D
{
    public class Point3D
    {
        private static readonly int[] startingPoints = {0,0,0};
        public static int[] StartingPoints
        {
            get { return startingPoints; }
        }

        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return this.x; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                if (value == null)
                    throw new ArgumentNullException();

                this.x = value;
            }
        }
        public double Y
        {
            get { return this.y; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                if (value == null)
                    throw new ArgumentNullException();

                this.y = value;
            }
        }
        public double Z
        {
            get { return this.z; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                if (value == null)
                    throw new ArgumentNullException();

                this.z = value;
            }
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return (x).ToString()+y+z;
        }
    }
}
