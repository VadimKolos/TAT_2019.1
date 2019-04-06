using System;

namespace ClassTask3
{
    /// <summary>
    /// This struct make a point from two coordinates.
    /// </summary>
    struct Point
    {
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }

        /// <summary>
        /// This constructor initialize X and Y coordinates.
        /// </summary>
        /// <param name="x">coordinate value</param>
        /// <param name="y">coordinate value</param>
        public Point(int x, int y)
        {
            coordinateX = x;
            coordinateY = y;
        }

        /// <summary>
        /// This method calculates length of the side of triangle.
        /// </summary>
        /// <param name="point">point of the triangle</param>
        /// <returns>triangle side length</returns>
        public double calculateSideOfTriangle(Point point)
        {
           double sideOfTriangle = Math.Sqrt((coordinateX - point.coordinateX) * (coordinateX - point.coordinateX) 
               + (coordinateY - point.coordinateY) * (coordinateY - point.coordinateY));
            return sideOfTriangle;
        }
    }
}
