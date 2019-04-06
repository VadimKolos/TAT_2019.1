namespace ClassTask3
{
    /// <summary>
    /// Abstract class for triangle builders.
    /// </summary>
    abstract class Builder
    {
        /// <summary>
        /// Initializes successor.
        /// </summary>
        public Builder Successor { get; set; }

        /// <summary>
        /// Abstract method takes three points.       
        /// </summary>
        /// <param name="point1">First point of the triangle</param>
        /// <param name="point2">Second point of the triangle</param>
        /// <param name="point3">Third point of the triangle</param>       
        public abstract Triangle BuilderRequest(Point point1, Point point2, Point point3);
    }
}
