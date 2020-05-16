using UnityEngine;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private readonly float _length;
        private readonly float _breadth;
        private readonly Vector3 _position;

        public Rectangle(float length, float breadth)
        {
            _length = length;
            _breadth = breadth;
            _position = Vector3.zero;
        }

        public override float Area()
        {
            return _length * _breadth;
        }

        public override float Perimeter()
        {
            return 2 * (_length + _breadth);
        }

        public override bool IsInside(float x, float y)
        {
            return InRange(_position.x, _breadth, x) && 
                   InRange(_position.y, _length, y);
        }

        private static bool InRange(float center, float width, float point)
        {
            return center - width / 2 < point && center + width / 2 > point;
        }
    }
}