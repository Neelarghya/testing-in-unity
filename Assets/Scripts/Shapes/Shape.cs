using UnityEngine;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract float Area();
        public abstract float Perimeter();

        public virtual bool isGreaterThan(Shape shape)
        {
            return true;
        }

        public abstract bool IsInside(float x, float y);
    }
}