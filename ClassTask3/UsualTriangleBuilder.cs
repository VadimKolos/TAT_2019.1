using System;

namespace ClassTask3
{
    class UsualTriangleBuilder : Builder
    {
        public UsualTriangleBuilder(Builder builder)
        {           
        }

        public override Triangle BuilderRequest(Point pointA, Point pointB, Point pointC)
        {
            if (pointA.coordinateX != pointB.coordinateX && pointB.coordinateX != pointC.coordinateX && pointC.coordinateX
                != pointA.coordinateX && pointA.coordinateY != pointB.coordinateY && pointB.coordinateY != pointC.coordinateY &&
                pointC.coordinateY != pointA.coordinateY)
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
