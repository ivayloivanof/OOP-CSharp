﻿using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    class DistanceCalculator
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            return Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2)
                + Math.Pow(point2.Z - point1.Z, 2);
        }
    }
}
