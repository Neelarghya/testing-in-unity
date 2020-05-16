namespace Shapes
{
    public class Rectangle : IShape
    {
        private float _length, _breadth;

        public Rectangle(float length, float breadth)
        {
            _length = length;
            _breadth = breadth;
        }

        public float Area()
        {
            return _length * _breadth;
        }

        public float Perimeter()
        {
            return 2 * (_length + _breadth);
        }
    }
}