using System;

namespace task_DEV5
{
    class Plane : IFlyable
    {
        Point point;
        public int newCoordinateX { get; set; }
        public int newCoordinateY { get; set; }
        public int newCoordinateZ { get; set; }
                
        public int [] FlyTo(Point newPoint)
        {
            newCoordinateX = newPoint.coordinateX;
            newCoordinateY = newPoint.coordinateY;
            newCoordinateZ = newPoint.coordinateZ;
            int[] endPoint = { newCoordinateX, newCoordinateY, newCoordinateZ };
            return endPoint;
        }

        public string WhoAmI()
        {
            return "Plane";
        }

        public double GetFlyTime(int [] endPoint)
        {
            double timeOfFlying = 0;
            var speed = 200;
            var distance = Math.Sqrt((newCoordinateX - point.coordinateX) ^ 2 + (newCoordinateY - point.coordinateY) ^ 2
                + (newCoordinateZ - point.coordinateZ));
            while (distance <= 10)
            {
                timeOfFlying = timeOfFlying + 10 / speed;
                distance = distance - 10;
                speed = speed + 10;
            }
            timeOfFlying += distance / speed;
            return timeOfFlying;           
        }
    }
}
