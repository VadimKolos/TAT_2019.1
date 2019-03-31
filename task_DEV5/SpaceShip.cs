using System;

namespace task_DEV5
{
    class SpaceShip : IFlyable
    {
        Point point;
        public int newCoordinateX { get; set; }
        public int newCoordinateY { get; set; }
        public int newCoordinateZ { get; set; }

        public int[] FlyTo(Point newPoint)
        {
            newCoordinateX = newPoint.coordinateX;
            newCoordinateY = newPoint.coordinateY;
            newCoordinateZ = newPoint.coordinateZ;

            int[] endPoint = { newCoordinateX, newCoordinateY, newCoordinateZ };
            return endPoint;
        }

        public string WhoAmI()
        {
            return "Space ship";
        }

        public double GetFlyTime(int[] endPoint)
        {
            int speed = 28800000;
            var timeOfFlying = Math.Sqrt((newCoordinateX - point.coordinateX) ^ 2 + (newCoordinateY - point.coordinateY) ^ 2
                + (newCoordinateZ - point.coordinateZ) ^ 2) / speed;
            return timeOfFlying;
        }
    }
}
