namespace ClassTask3
{
    abstract class Triangle
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }
        public Point PointC { get; set; }
        public double AB { get; set; }
        public double BC { get; set; }
        public double CA { get; set; }
        public double TriangleSquare { get; set; }

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
