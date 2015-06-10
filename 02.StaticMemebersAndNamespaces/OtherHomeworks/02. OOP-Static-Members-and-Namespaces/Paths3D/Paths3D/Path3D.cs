using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths3D
{
    class Path3D
    {
        public List<Point> path { get; set; }

        public Path3D(List<Point> path)
        {
            this.path = path;
        }

    }
}
