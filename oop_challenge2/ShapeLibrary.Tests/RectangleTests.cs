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
    public class RectangleTests
    {
        [TestCase(5, 10, 50)]
        [TestCase(4, 6, 24)]
        [TestCase(9, 7, 63)]
        public void GetArea_ValidInput_CorrectOutput(double side1, double side2, double expected)
        {
            // Arrange
            Rectangle tested = new Rectangle(side1, side2);

            // Act
            double actual = GetArea(tested);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 10, 30)]
        [TestCase(4, 6, 20)]
        [TestCase(9, 7, 32)]
        public void GetPerimeter_ValidInput_CorrectOutput(double side1, double side2, double expected)
        {
            // Arrange
            Rectangle tested = new Rectangle(side1, side2);

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
