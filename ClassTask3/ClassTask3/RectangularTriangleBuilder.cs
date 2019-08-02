using System;

namespace ClassTask3
{
    /// <summary>
    /// This class builds rectangular triangles.
    /// </summary>
    class RectangularTriangleBuilder : Builder
    {       
        public RectangularTriangleBuilder(Builder builder)
        {
            Successor = builder;
        }
        private const double _epsilon = 0.0000000001;

        /// <summary>
        /// This method checks if the triangle is rectangular.
        /// <summary>
        /// <param name="pointA">First point of the triangle</param>
        /// <param name="pointB">Second point of the triangle</param>
        /// <param name="pointC">Third point of the triangle</param>
        public override Triangle BuilderRequest(Point pointA, Point pointB, Point pointC)
        {
            double AB = pointA.calculateSideOfTriangle(pointB);
            double BC = pointB.calculateSideOfTriangle(pointC);
            double CA = pointC.calculateSideOfTriangle(pointA);

            if ((AB > BC && AB > CA && (Math.Pow(AB, 2) - (Math.Pow(CA, 2) + Math.Pow(BC, 2))) < _epsilon) ||
               (BC > AB && BC > CA && (Math.Pow(BC, 2) - (Math.Pow(CA, 2)  + Math.Pow(AB, 2))) < _epsilon) ||
               (CA > AB && CA > BC && (Math.Pow(CA, 2) - (Math.Pow(BC, 2)  + Math.Pow(AB, 2))) < _epsilon))
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


