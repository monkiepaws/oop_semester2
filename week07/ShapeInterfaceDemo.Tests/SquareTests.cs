using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ShapeInterfaceDemo;

namespace ShapeInterfaceDemo.Tests
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        [TestCase(5, 5)]
        [TestCase(11, 11)]
        [TestCase(55, 55)]
        public void Constructor_IsCalled_Property_set(int input, int expected)
        {
            // Arrange
            Square sq = new Square(input);

            // Assert
            Assert.That(sq.SideLength.Equals(expected));
        }

        [Test]
        [TestCase(5, 25)]
        [TestCase(8, 64)]
        [TestCase(2, 4)]
        public void GetArea_ValidInputs_CorrectOutput(int input, int expected)
        {
            // Arrange
            Square sq = new Square(input);

            // Act
            double test = sq.GetArea();

            // Assert
            Assert.That(test.Equals(expected));
        }

        [Test]
        [TestCase(5, 20)]
        [TestCase(8, 32)]
        [TestCase(2, 8)]
        public void GetPerimeter_ValidInputs_CorrectOutput(int input, int expected)
        {
            // Arrange
            Square sq = new Square(input);

            // Act
            double test = sq.GetPerimeter();

            // Assert
            Assert.That(test.Equals(expected));
        }

        [Test]
        [TestCase(5, "HELLOTHERE", "Square: HELLOTHERE")]
        [TestCase(8, "SCONES", "Square: SCONES")]
        [TestCase(2, "COFFEE", "Square: COFFEE")]
        public void EchoInput_ValidInputs_CorrectOutput(int input, string pInput, string expected)
        {
            // Arrange
            Square sq = new Square(input);

            // Act
            string test = sq.EchoInput(pInput);

            // Assert
            Assert.That(test.Equals(expected));
        }
    }
}
