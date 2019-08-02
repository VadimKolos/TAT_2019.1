using System;

namespace ClassTask3
{
    /// <summary>
    /// This class builds equilateral triangles.
    /// </summary>
    class EquilateralTriangleBuilder : Builder
    {
        public EquilateralTriangleBuilder(Builder builder)
        {
            Successor = builder;
        }

        /// <summary>
        /// This method checks if the triangle is equilateral.
        /// <summary>
        /// <param name="pointA">First point of the triangle</param>
        /// <param name="pointB">Second point of the triangle</param>
        /// <param name="pointC">Third point of the triangle</param>
        public override Triangle BuilderRequest(Point pointA, Point pointB, Point pointC)
        {
            double AB = pointA.calculateSideOfTriangle(pointB);
            double BC = pointB.calculateSideOfTriangle(pointC);
            double CA = pointC.calculateSideOfTriangle(pointA);

            if (AB - BC < 0.000001 &&  BC - CA < 0.000001)
            {
               return new EquilateralTriangle(pointA, pointB, pointC);
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
