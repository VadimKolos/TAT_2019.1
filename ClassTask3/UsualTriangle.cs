using System;

namespace ClassTask3
{
    class UsualTriangle : Triangle
    {        
        public UsualTriangle(Point pointA, Point pointB, Point pointC) : base(pointA, pointB, pointC)
        {            
            TriangleSquare = Math.Sqrt(3.0) * AB / 4;
        }
       
    }
}
