//-----------------------------------------------------------------------
// <copyright file="PathStorage.cs" company = "SoftUni">
// Copyright (c) SoftUni. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
/* Problem 3. Create a class Path3D to hold a sequence of points in 3D space. Create a static class Storage with static methods to save and load paths from a text file. Use a file format of your choice. Ensure you close correctly all files with the "using" statement.*/

using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _01.Point3D
{
    public static class Storage
    {
    public static void SavePathToFile(string filePath, string path)
        {
        using (StreamWriter writer = new StreamWriter(filePath))
            {
            writer.WriteLine(path);
            }
        }

    public static Path3D LoadPathFromFile(string filepath)
        {
        Path3D path = new Path3D();

        using (StreamReader reader = new StreamReader(filepath))
            {
            string line = reader.ReadLine();
            const string PointPattern = @"[xyz=:\-\s](\d+(?:(?:\.|,)\d+)*)";

            while (line != null)
                {
                MatchCollection matches = Regex.Matches(line, PointPattern);
                if (matches.Count == 3)
                    {
                    double x = double.Parse(matches[0].Groups[1].Value);
                    double y = double.Parse(matches[1].Groups[1].Value);
                    double z = double.Parse(matches[2].Groups[1].Value);

                    Point3D point = new Point3D(x, y, z);
                    path.AddPoints(point);
                    }

                line = reader.ReadLine();
                }
            }
        return path;
        }
    }
}
