using System;

namespace ClassTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point point1 = new Point(2, 2);
                Point point2 = new Point(2, 4);
                Point point3 = new Point(3, 2);
                Builder builder = new RectangularTriangleBuilder(new EquilateralTriangleBuilder(new UsualTriangleBuilder(null)));
                Triangle triangle = builder.BuilderRequest(point1, point2, point3);
                Console.WriteLine("Square of ​​a given triangle: " + triangle.TriangleSquare);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
