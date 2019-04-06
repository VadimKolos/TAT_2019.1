namespace ClassTask3
{
    /// <summary>
    /// This class work with rectangular triangles.
    /// </summary>
    class RectangularTriangle : Triangle
    {
        /// <summary>
        /// This constructor calculates square of rectangular triangle.
        /// </summary>
        /// <param name="point1">First point of the triangle</param>
        /// <param name="point2">Second point of the triangle</param>
        /// <param name="point3">Third point of the triangle</param>
        public RectangularTriangle(Point pointA, Point pointB, Point pointC) : base(pointA, pointB, pointC)
        {
            if (AB > BC && AB > CA)
            {
                TriangleSquare = BC * CA / 2;
            }
            else if (BC > AB && BC > CA)
            {
                TriangleSquare = AB * CA / 2;
            }
            else
            {
                TriangleSquare = AB * BC / 2;
            }
            triangleType = "rectangular";
        }       
    }
}
