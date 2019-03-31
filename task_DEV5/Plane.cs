using System;

namespace task_DEV5
{
    /// <summary>
    /// This class work with parametres of plane.
    /// </summary>
    class Plane : IFlyable
    {
        Point point;

        /// <summary>
        /// Final coordinates of plane.
        /// </summary>
        public int newCoordinateX { get; set; }
        public int newCoordinateY { get; set; }
        public int newCoordinateZ { get; set; }

        /// <summary>
        /// This method returns final point of plane.
        /// </summary>
        /// <param name="newPoint">final point</param>
        /// <param name="endPoint">Array of x, y, z - parametres of final point</param>
        public int[] FlyTo(Point newPoint)
        {
            newCoordinateX = newPoint.coordinateX;
            newCoordinateY = newPoint.coordinateY;
            newCoordinateZ = newPoint.coordinateZ;
            int[] endPoint = { newCoordinateX, newCoordinateY, newCoordinateZ };
            return endPoint;
        }

        /// <summary>
        /// This method returns name of this object (plane).
        /// </summary>
        public string WhoAmI()
        {
            return "Plane";
        }

        /// <summary>
        /// This method calculates flight time of the plane, whoose start speed - 200 km/h.        
        /// </summary>        
        /// <param name="endPoint">Array of x, y, z - parametres of final point</param>
        /// <param name="distance">Distance between start point and finite point</param>
        /// <param name="timeOfFlying">time of flying of the plane</param>
        public double GetFlyTime(int[] endPoint)
        {
            double timeOfFlying = 0;
            var speed = 200;
            var distance = Math.Sqrt((newCoordinateX - point.coordinateX) ^ 2 + (newCoordinateY - point.coordinateY) ^ 2
                + (newCoordinateZ - point.coordinateZ));

            /// <summary>
            /// Plane has speed +10 km/hour each 10 km.        
            /// </summary> 
            while (distance <= 10)
            {
                timeOfFlying = (timeOfFlying + 10) / speed;
                distance = distance - 10;
                speed = speed + 10;
            }
            timeOfFlying = (timeOfFlying + distance) / speed;
            return timeOfFlying;
        }
    }
}
