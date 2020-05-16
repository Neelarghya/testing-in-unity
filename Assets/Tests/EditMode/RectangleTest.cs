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
    }
}
