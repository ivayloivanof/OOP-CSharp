//-----------------------------------------------------------------------
// <copyright file="Point3D.cs" company = "SoftUni">
// Copyright (c) SoftUni. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

/* Problem 1. Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Create appropriate constructors. Override ToString() to enable printing a 3D point.
Add a private static read-only field in the Point3D class to hold the start of the coordinate system – the point StartingPoint {0, 0, 0}. Add a static property to return the starting point.*/

using System;

namespace _01.Point3D
    {
    using System.Text;

    /// <summary>
    /// Constructs a 3D Point
    /// </summary>
    public struct Point3D
        {
        private static readonly Point3D PointO;

        static Point3D()
            {
            PointO = new Point3D(0, 0, 0);
            }

        public Point3D(double x, double y, double z)
            : this()
            {
            this.X = x;
            this.Y = y;
            this.Z = z;
            }

        public static Point3D StartPointO
            {
            get
                {
                return PointO;
                }
            }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
            {
            var result = new StringBuilder();
            result.AppendFormat("\nX: {0}", this.X);
            result.AppendFormat("\nY: {0}", this.Y);
            result.AppendFormat("\nZ: {0}", this.Z);
            return result.ToString();
            }
        }
    }
