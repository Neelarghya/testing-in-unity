namespace Shapes
{
    public abstract class Shape
    {
        public abstract float Area();
        public abstract float Perimeter();

        public bool IsGreaterThan(Shape shape)
        {
            return Area() > shape.Area();
        }

        public abstract bool IsInside(float x, float y);
    }
}