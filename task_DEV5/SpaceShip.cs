using System;

namespace task_DEV5
{
    /// <summary>
    /// This class work with parametres of space ship.
    /// </summary>
    class SpaceShip : IFlyable
    {
        Point point;

        /// <summary>
        /// Final coordinates of space ship.
        /// </summary>
        public int newCoordinateX { get; set; }
        public int newCoordinateY { get; set; }
        public int newCoordinateZ { get; set; }

        /// <summary>
        /// This method returns final point of space ship.
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
        /// This method returns name of this object.
        /// </summary>
        public string WhoAmI()
        {
            return "Space ship";
        }

        /// <summary>
        /// This method calculates flight time of the space ship, whoose speed - 28800000 km/h.        
        /// </summary>        
        /// <param name="endPoint">Array of x, y, z - parametres of final point</param>
        /// <param name="distance">Distance between start point and finite point</param>
        /// <param name="timeOfFlying">time of flying of the space ship</param>
        public double GetFlyTime(int[] endPoint)
        {
            int speed = 28800000;
            var timeOfFlying = Math.Sqrt((newCoordinateX - point.coordinateX) ^ 2 + (newCoordinateY - point.coordinateY) ^ 2
                + (newCoordinateZ - point.coordinateZ) ^ 2) / speed;
                
            return timeOfFlying;
        }
    }
}
