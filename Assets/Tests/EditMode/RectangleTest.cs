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
        
        [Test]
        public void PointsShouldBeInsideRectangle([Range(-2, 2)] float x,
            [Range(-1, 1)] float y)
        {
            const float length = 3;
            const float breadth = 5;

            Rectangle rectangle = new Rectangle(length, breadth);

            Assert.IsTrue(rectangle.IsInside(x, y));
        }

        [Test]
        public void PointsOnLeftOrRightShouldBeOutsideRectangle(
            [Values(-3, 3)] float x, [Range(-2, 2)] float y)
        {
            const float length = 3;
            const float breadth = 5;

            Rectangle rectangle = new Rectangle(length, breadth);

            Assert.IsFalse(rectangle.IsInside(x, y));
        }

        [Test]
        public void PointsAboveOrBelowShouldBeOutsideRectangle(
            [Range(-3, 3)] float x, [Values(-2, 2)] float y)
        {
            const float length = 3;
            const float breadth = 5;

            Rectangle rectangle = new Rectangle(length, breadth);

            Assert.IsFalse(rectangle.IsInside(x, y));
        }

        [Test]
        public void RandomPointsShouldBeInsideRectangle(
            [Random(-2f, 2f, 2)] float x,
            [Random(-1f, 1f, 2)] float y)
        {
            const float length = 3;
            const float breadth = 5;

            Rectangle rectangle = new Rectangle(length, breadth);

            Assert.IsTrue(rectangle.IsInside(x, y));
        }

        private static object[] _cases = {
            new object[]{ new Rectangle(1, 1), new Rectangle(1, 1), false},
            new object[]{ new Rectangle(2, 1), new Rectangle(3, 1), false},
            new object[]{ new Rectangle(2, 2), new Rectangle(1, 3), true},
            new object[]{ new Rectangle(5, 4), new Rectangle(6, 3), true}
        };

        [TestCaseSource(nameof(_cases))]
        public void CheckWhichRectangleIsBigger(
            Rectangle first, Rectangle second, bool isGreater)
        {
            Assert.AreEqual(isGreater, first.IsGreaterThan(second));
        }

        private static Rectangle[] _rectangles =
        {
            new Rectangle(2, 3),
            new Rectangle(4, 2),
            new Rectangle(1, 5),
            new Rectangle(7, 3)
        };

        [Test, Sequential]
        public void TestPerimeterOfARectangle(
            [ValueSource(nameof(_rectangles))] Rectangle rectangle, 
            [Values(10, 12, 12, 20)] float perimeter)
        {
            Assert.AreEqual(perimeter, rectangle.Perimeter());
        }
    }
}