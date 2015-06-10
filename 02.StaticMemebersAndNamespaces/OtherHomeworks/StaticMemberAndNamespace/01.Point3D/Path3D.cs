//-----------------------------------------------------------------------
// <copyright file="Path.cs" company = "SoftUni">
// Copyright (c) SoftUni. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
/* Problem 3. Create a class Path3D to hold a sequence of points in 3D space. Create a static class Storage with static methods to save and load paths from a text file. Use a file format of your choice. Ensure you close correctly all files with the "using" statement.*/

namespace _01.Point3D
    {
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Path for holding a sequence of 3D Points - Problem 4
    /// </summary>
    public class Path3D
        {
        private readonly List<Point3D> path = new List<Point3D>();

        public Path3D(params Point3D[] list)
            {
            this.AddPoints(list);
            }

        public List<Point3D> Path
            {
            get { return this.path; }
            }

        public void AddPoints(params Point3D[] list)
            {
            foreach (var point3D in list)
                {
                this.path.Add(point3D);
                }
            }

        public override string ToString()
            {
            StringBuilder result = new StringBuilder("Path:\n");
            for (int i = 0; i < this.Path.Count; i++)
                {
                result.AppendFormat("point{0}: x={1} y={2} z={3}\n", i + 1, this.Path[i].X, this.Path[i].Y, this.Path[i].Z);
                }

            return result.ToString();
            }
        }
    }
