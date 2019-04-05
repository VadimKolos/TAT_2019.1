using System;

namespace ClassTask3
{
    struct Point
    {
        public float coordinateX { get; set; }
        public float coordinateY { get; set; }

        public Point(float x, float y)
        {
            coordinateX = x;
            coordinateY = y;
        }

        public float calculateSideOfTriangle(Point point)
        {
           float sideOfTriangle = (float)Math.Sqrt((coordinateX - point.coordinateX) * (coordinateX - point.coordinateX) 
               + (coordinateY - point.coordinateY) * (coordinateY - point.coordinateY));
            return sideOfTriangle;
        }
    }
}
