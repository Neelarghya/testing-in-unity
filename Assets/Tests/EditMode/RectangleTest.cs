﻿using NUnit.Framework;
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
                [Values(-3,3)] float x, [Range(-2, 2)] float y)
        {
            const float length = 3;
            const float breadth = 5;

            Rectangle rectangle = new Rectangle(length, breadth);

            Assert.IsFalse(rectangle.IsInside(x, y));
        }
        
        [Test]
        public void PointsAboveOrBelowShouldBeOutsideRectangle(
                [Range(-3,3)] float x, [Values(-2, 2)] float y)
        {
            const float length = 3;
            const float breadth = 5;

            Rectangle rectangle = new Rectangle(length, breadth);

            Assert.IsFalse(rectangle.IsInside(x, y));
        }
    }
}