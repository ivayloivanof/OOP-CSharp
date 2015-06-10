//-----------------------------------------------------------------------
// <copyright file="ClassDistance.cs" company = "SoftUni">
// Copyright (c) SoftUni. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
/* Problem 2. Write a static class DistanceCalculator with a static method to calculate the distance between two points in the 3D space. Search in Internet how to calculate distance in the 3D Euclidian space.*/

namespace _01.Point3D
    {
    using System;

    /// <summary>
    /// A static class with a static method which calculates distance between two points - Problem 3
    /// </summary>
    public static class DistanceCalculator
        {
        /// <summary>
        /// Calculates the distance between two points in 3D space
        /// </summary>
        /// <returns>returns the Euclidean distance</returns>
        public static double CalculateDistance(Point3D p, Point3D q)
            {
            return Math.Sqrt(Math.Pow(p.Y - q.X, 2) + Math.Pow(p.Y - q.Y, 2) + Math.Pow(p.Z - q.Z, 2));
            }
        }
    }
