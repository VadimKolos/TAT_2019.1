namespace task_DEV5
{
    /// <summary>
    /// Interface for Bird, Plane and SpaceShip.
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        /// This method takes finit coordinates.
        /// </summary>
        /// <param name="newPoint">final point</param>
        int[] FlyTo(Point newPoint);

        /// <summary>
        /// This method returns name of the object.
        /// </summary>        
        string WhoAmI();

        /// <summary>
        /// This method calculates time for fly of object (plane, bird, space ship).
        /// </summary>  
        /// <param name="coordinateArray">set three final coordinates</param>
        double GetFlyTime(int[] coordinateArray);
    }
}
