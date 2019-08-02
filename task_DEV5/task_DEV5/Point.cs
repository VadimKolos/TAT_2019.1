namespace task_DEV5
{
    /// <summary>
    /// Three-dimensional point structure.
    /// </summary>
    public struct Point
    {
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }
        public int coordinateZ { get; set; }

        /// <summary>
        /// This constructor takes start coordinates of point.
        /// </summary>
        /// <param name="x, y, z">values of coordinates of start point</param>
        public Point(int x, int y, int z)
        {
            coordinateX = x;
            coordinateY = y;
            coordinateZ = z;
        }
    }
}
