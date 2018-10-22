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
    public class EquilateralTests
    {
        [TestCase(5, 10.83)]
        [TestCase(15, 97.43)]
        [TestCase(7, 21.22)]
        public void GetArea_ValidInput_CorrectOutput(double side1, double expected)
        {
            // Arrange
            Equilateral tested = new Equilateral(side1);

            // Act
            double actual = GetArea(tested);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 15)]
        [TestCase(15, 45)]
        [TestCase(7, 21)]
        public void GetPerimeter_ValidInput_CorrectOutput(double side1, double expected)
        {
            // Arrange
            Equilateral tested = new Equilateral(side1);

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
