using System;

namespace ClassTask3
{
    class EquilateralTriangleBuilder : Builder
    {
        public EquilateralTriangleBuilder(Builder builder)
        {           
        }

        public override Triangle BuilderRequest(Point pointA, Point pointB, Point pointC)
        {
            if (pointA.calculateSideOfTriangle(pointB) - pointB.calculateSideOfTriangle(pointB) ==0 &&
                pointB.calculateSideOfTriangle(pointC) - pointC.calculateSideOfTriangle(pointA) ==0)
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
