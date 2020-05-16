using NUnit.Framework;
using Shapes;

namespace Tests
{
    public class RectangleTest
    {
        [TestCase(2, 3, 6)]
        [TestCase(7, 5, 35)]
        public void TestAreaOfRectangleArea(float length, float breadth, 
                                        float area)
        {
            Rectangle rectangle = new Rectangle(length, breadth);
            Assert.AreEqual(area, rectangle.Area());
        }
        
        [TestCase(0, 0, true)]
        [TestCase(3, 3, false)]
        public void TestIfPointIsInsideRectangle(float x, float y, 
            bool isInside)
        {
            const float length = 3;
            const float breadth = 5;
    
            Rectangle rectangle = new Rectangle(length, breadth);
    
            Assert.AreEqual(isInside, rectangle.IsInside(x, y));
        }
    }
}
