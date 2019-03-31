using System;

namespace task_DEV5
{
    class Bird : IFlyable
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
            return "Bird";
        }

        public double GetFlyTime(int [] endPoint)
        {
            Random random = new Random();
            int speed = random.Next(0, 20);
            var timeToFly = Math.Sqrt((newCoordinateX - point.coordinateX) ^ 2 + (newCoordinateY - point.coordinateY) ^ 2
                + (newCoordinateZ - point.coordinateZ)) / speed;
            return timeToFly;
        }
    }
}
