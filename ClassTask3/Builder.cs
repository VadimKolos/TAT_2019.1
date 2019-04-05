namespace ClassTask3
{
    abstract class Builder
    {
        public Builder Successor { get; set; }
        public abstract Triangle BuilderRequest(Point point1, Point point2, Point point3);
    }
}
