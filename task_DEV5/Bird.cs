using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV5
{
    class Bird : IFlyable
    {
        Point point;
        public int newCoordinateX { get; set; }
        public int newCoordinateY { get; set; }
        public int newCoordinateZ { get; set; }

        double speed = 0;

        public void FlyTo(Point newPoint)
        {
            newCoordinateX = newPoint.coordinateX;
            newCoordinateY = newPoint.coordinateY;
            newCoordinateZ = newPoint.coordinateZ;
        }

        public string WhoAmI()
        {
            return "Bird";
        }

        public double GetFlyTime()
        {
            return speed;
        }
    }
}
