using NUnit.Framework;
using Shapes;

namespace Tests
{
    public class RectangleTest
    {
        [Test]
        public void TestAreaOfRectangleWithLength2AndBreadth3()
        {
            Rectangle rectangle = new Rectangle(2, 3);
            Assert.AreEqual(6, rectangle.Area());
        }
    }
}
