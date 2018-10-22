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
    public class SquareTests
    {
        [TestCase(5, 25)]
        [TestCase(15, 225)]
        [TestCase(7, 49)]
        public void GetArea_ValidInput_CorrectOutput(double side1, double expected)
        {
            // Arrange
            Square tested = new Square(side1);

            // Act
            double actual = GetArea(tested);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 20)]
        [TestCase(15, 60)]
        [TestCase(7, 28)]
        public void GetPerimeter_ValidInput_CorrectOutput(double side1, double expected)
        {
            // Arrange
            Square tested = new Square(side1);

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
