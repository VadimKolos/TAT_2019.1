using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV5
{
    public struct Point
    {
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }
        public int coordinateZ { get; set; }

        public Point(int x, int y, int z)
        {
            coordinateX = x;
            coordinateY = y;
            coordinateZ = z;
        }
    }
}
