using System;

namespace ClassTask3
{
    /// <summary>
    /// This class work with equilateral triangles.
    /// </summary>
    class EquilateralTriangle : Triangle
    {
        /// <summary>
        /// This constructor calculates square of equilateral triangle.
        /// </summary>
        /// <param name="pointA">First point of the triangle</param>
        /// <param name="pointB">Second point of the triangle</param>
        /// <param name="pointC">Third point of the triangle</param>
        public EquilateralTriangle(Point pointA, Point pointB, Point pointC) : base(pointA, pointB, pointC)
        {
            TriangleSquare = Math.Sqrt(3.0) * AB / 4;
            triangleType = "equilateral";
        }       
    }
}
