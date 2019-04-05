using System;

namespace ClassTask3
{
    class RectangularTriangleBuilder : Builder
    {
        public RectangularTriangleBuilder(Builder builder)
        {           
        }

        public override Triangle BuilderRequest(Point pointA, Point pointB, Point pointC)
        {
            if (pointA.coordinateX == pointB.coordinateY && pointB.coordinateY == pointC.coordinateY)
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


