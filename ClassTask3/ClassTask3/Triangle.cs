namespace ClassTask3
{
    /// <summary>
    /// This abstract class works with triangle arguments.
    /// </summary>
    abstract class Triangle
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }
        public Point PointC { get; set; }
        public double AB { get; set; }
        public double BC { get; set; }
        public double CA { get; set; }
        public double TriangleSquare { get; set; }
        public string triangleType { get; set; }

        /// <summary>
        /// This constructor initialize points and sides of triangle.
        /// </summary>
        /// <param name="point1">First point of the triangle</param>
        /// <param name="point2">Second point of the triangle</param>
        /// <param name="point3">Third point of the triangle</param>
        public Triangle(Point point1, Point point2, Point point3)
        {
            PointA = point1;
            PointB = point2;
            PointC = point3;
            AB = PointA.calculateSideOfTriangle(PointB);
            BC = PointB.calculateSideOfTriangle(PointC);
            CA = PointC.calculateSideOfTriangle(PointA);
        }
    }
}
