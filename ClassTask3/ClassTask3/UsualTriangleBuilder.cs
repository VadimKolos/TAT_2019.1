using System;

namespace ClassTask3
{
    /// <summary>
    /// This class builds usual triangles.
    /// </summary>
    class UsualTriangleBuilder : Builder
    {
        public UsualTriangleBuilder(Builder builder)
        {
            Successor = builder;
        }
        /// <summary>
        /// This method checks whether the entered points form a triangle.
        /// </summary>
        /// <param name="pointA">First point of the triangle</param>
        /// <param name="pointB">Second point of the triangle</param>
        /// <param name="pointC">Third point of the triangle</param>        
        public override Triangle BuilderRequest(Point pointA, Point pointB, Point pointC)
        {
            if (!(pointA.coordinateX == pointB.coordinateX && pointB.coordinateX == pointC.coordinateX && pointC.coordinateX
                == pointA.coordinateX) || !(pointA.coordinateY != pointB.coordinateY && pointB.coordinateY != pointC.coordinateY &&
                pointC.coordinateY != pointA.coordinateY))
            {
                return new RectangularTriangle(pointA, pointB, pointC);
            }
            else if (Successor != null)
            {
                return Successor.BuilderRequest(pointA, pointB, pointC);
            }
            else
            {
                throw new FormatException("request not processed");
            }
        }
    }
}
