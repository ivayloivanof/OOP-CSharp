//-----------------------------------------------------------------------
// <copyright file="Point3DMain.cs" company = "SoftUni">
// Copyright (c) SoftUni. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Point3D
    {
    using System;

    /// <summary>
    /// Public class Structure
    /// </summary>
    public static class Structure
        {
        /// <summary>
        /// The Main method
        /// </summary>
        public static void Main()
            {
            // Testing Problem 1
            Point3D point = new Point3D(0, -15, 90.5);
            Console.WriteLine("Problem 1.");
            Console.WriteLine("The starting point: {0}", Point3D.StartPointO);
            Console.WriteLine("Printing a 3D point: {0}", point);
            Console.WriteLine();

            // Testing Problem 2
            Point3D point3 = new Point3D(0, 5, 1);
            Point3D point4 = new Point3D(2, -5, 17);
            Console.WriteLine("Problem 2.");
            Console.WriteLine("The distance between the points is: {0}", DistanceCalculator.CalculateDistance(point3, point4));
            Console.WriteLine();

            // Testing problem 3
            Point3D point5 = new Point3D(0, 55, 2);
            Point3D point6 = new Point3D(22, 20, -1);
            Path3D path = new Path3D(point5, point6);
            Console.WriteLine("Problem 3.");
            Storage.SavePathToFile("../../path.txt", path.ToString());
            Console.WriteLine("Loading from file:\n" + Storage.LoadPathFromFile("../../path.txt"));
            }
        }
    }
