using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Paths3D
{
    class Storage
    {
        public static Path3D LoadPath(int choice,Path3D somePath3D)
        {
            string path = "../../paths/" + "path" + choice.ToString() + ".txt";  
            somePath3D = new Path3D(new List<Point>());
            string line = "-";
            StreamReader someReader=new StreamReader(path);
            while (true)
            {
                line = someReader.ReadLine();
                if (String.IsNullOrEmpty(line)) break;
                double x = double.Parse(line[0].ToString());
                double y = double.Parse(line[1].ToString());
                double z = double.Parse(line[2].ToString());
                somePath3D.path.Add(new Point(x,y,z));
            }
            return somePath3D;
        }

        public static void SavePath(Path3D somePath3D)
        {
            string path = "../../paths/UserMade.txt";
            StreamWriter someWriter = new StreamWriter(path);
            for (int i = 0; i < somePath3D.path.Count; i++)
            {
                someWriter.WriteLine(somePath3D.path[i].ToString());
            }
            someWriter.Close();
        }
    }
}
