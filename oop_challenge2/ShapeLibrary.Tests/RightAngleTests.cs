using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ShapeLibrary;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class RightAngleTests
    {
        [TestCase(5, 10, 25)]
        [TestCase(4, 6, 12)]
        [TestCase(9, 7, 31.5)]
        public void GetArea_ValidInput_CorrectOutput(double side1, double side2, double expected)
        {
            // Arrange
            RightAngle tested = new RightAngle(side1, side2);

            // Act
            double actual = GetArea(tested);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 10, 26.18)]
        [TestCase(4, 6, 17.21)]
        [TestCase(9, 7, 27.4)]
        public void GetPerimeter_ValidInput_CorrectOutput(double side1, double side2, double expected)
        {
            // Arrange
            RightAngle tested = new RightAngle(side1, side2);

            // Act
            double actual = GetPerimeter(tested);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public double GetPerimeter(IShapeData shape)
        {
            return shape.GetPerimeter();
        }

        public double GetArea(IShapeData shape)
        {
            return shape.GetArea();
        }
    }
}
