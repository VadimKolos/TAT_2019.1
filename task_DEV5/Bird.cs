using System;

namespace task_DEV5
{
    /// <summary>
    /// This class work with parametres of bird.
    /// </summary>
    class Bird : IFlyable
    {
        Point point;

        /// <summary>
        /// Final coordinates of bird.
        /// </summary>
        public int newCoordinateX { get; set; }
        public int newCoordinateY { get; set; }
        public int newCoordinateZ { get; set; }

        /// <summary>
        /// This method returns final point of bird.
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
            return "Bird";
        }

        /// <summary>
        /// This method calculates flight time of the bird, whoose start speed calculate randomly between 1-20 km/h.        
        /// </summary>        
        /// <param name="endPoint">Array of x, y, z - parametres of final point</param>
        /// <param name="distance">Distance between start point and finite point</param>
        /// <param name="timeOfFlying">time of flying of the bird</param>
        public double GetFlyTime(int[] endPoint)
        {
            Random random = new Random();
            int speed = random.Next(1, 20);
            var timeOfFlying = Math.Sqrt((newCoordinateX - point.coordinateX) ^ 2 + (newCoordinateY - point.coordinateY) ^ 2
                + (newCoordinateZ - point.coordinateZ)) / speed;

            return timeOfFlying;
        }
    }
}
