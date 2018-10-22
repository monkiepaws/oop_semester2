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
    public class CircleTests
    {
        [TestCase(5, 78.54d)]
        [TestCase(15, 706.86d)]
        [TestCase(7, 153.94d)]
        public void GetArea_ValidInput_CorrectOutput(double side1, double expected)
        {
            // Arrange
            Circle tested = new Circle(side1);

            // Act
            double actual = GetArea(tested);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 31.42)]
        [TestCase(15, 94.25)]
        [TestCase(7, 43.98)]
        public void GetPerimeter_ValidInput_CorrectOutput(double side1, double expected)
        {
            // Arrange
            Circle tested = new Circle(side1);


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
