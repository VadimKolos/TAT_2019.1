using System;

namespace ClassTask3
{
    /// <summary>
    /// This class work with usual triangles.
    /// </summary>
    class UsualTriangle : Triangle
    {
        /// <summary>
        /// This constructor calculates square of usual triangle.
        /// </summary>
        /// <param name="point1">First point of the triangle</param>
        /// <param name="point2">Second point of the triangle</param>
        /// <param name="point3">Third point of the triangle</param>
        public UsualTriangle(Point pointA, Point pointB, Point pointC) : base(pointA, pointB, pointC)
        {            
            TriangleSquare = Math.Sqrt(3.0) * AB / 4;
            triangleType = "usual";
        }
       
    }
}
