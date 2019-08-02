using System;

namespace ClassTask3
{
    /// <summary>
    /// Entry point of the program    
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point work with triangle and three points
        /// </summary>
        static void Main(string[] args)
        {            
            try
            {
                Point point1 = new Point(8, 2);
                Point point2 = new Point(20, 2);
                Point point3 = new Point(20, 8);
                Builder builder = new RectangularTriangleBuilder(new EquilateralTriangleBuilder(new UsualTriangleBuilder(null)));
                Triangle triangle = builder.BuilderRequest(point1, point2, point3);
                Console.WriteLine("Square of a " + triangle.triangleType + " triangle: " +  triangle.TriangleSquare);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}
