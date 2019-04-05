namespace ClassTask3
{
    class RectangularTriangle : Triangle
    {        
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
        }       
    }
}
