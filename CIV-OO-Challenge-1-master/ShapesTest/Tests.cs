using System;
using NUnit.Framework;
// remember to reference and import your shape library

namespace ShapesTest {
    [TestFixture]
    public class Tests {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }
        RightAngleTriangle ra1 { get; set; }
        EquilateralTriangle eq1 { get; set; }
        
        Square sq2 { get; set; }
        Rectangle rec2 { get; set; }
        RightAngleTriangle ra2 { get; set; }
        EquilateralTriangle eq2 { get; set; }


        [SetUp]
        public void Init() {
            sq1 = new Square("Blue", 4);
            rec1 = new Rectangle("Red", 4, 3);
            ra1 = new RightAngleTriangle("White", 3, 4);
            eq1 = new EquilateralTriangle("black", 6);
            
            sq2 = new Square("Blue", 6);
            rec2 = new Rectangle("Red", 5, 4);
            ra2 = new RightAngleTriangle("White", 7, 4);
            eq2 = new EquilateralTriangle("black", 8);
        }
        
        [Test]
        public void SquareTests() {
            int area = 16;
            int perimeter = 16;
            
            Assert.AreEqual(area, sq1.GetArea());
            Assert.AreEqual(perimeter, sq1.GetPerimeter());
            
            area = 36;
            perimeter = 24;
            
            Assert.AreEqual(area, sq2.GetArea());
            Assert.AreEqual(perimeter, sq2.GetPerimeter());

        }

        [Test]
        public void RectangleTests() {
            int area = 12;
            int perimeter = 14;
            
            Assert.AreEqual(area, rec1.GetArea());
            Assert.AreEqual(perimeter, rec1.GetPerimeter());

            area = 20;
            perimeter = 18;
            
            Assert.AreEqual(area, rec2.GetArea());
            Assert.AreEqual(perimeter, rec2.GetPerimeter());

        }
        
        [Test]
        public void RightAngleTriangleTests() {
            float area = 6;
            float perimeter = 12;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(ra1.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(ra1.GetPerimeter(), 2));
            area = 14;
            perimeter = 19.06f;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(ra2.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(ra2.GetPerimeter(), 2));

        }
        
        [Test]
        public void EquilateralTriangleTests() {
            float area = 15.59f;
            float perimeter = 18;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(eq1.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(eq1.GetPerimeter(), 2));
            
            area = 27.71f;
            perimeter = 24;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(eq2.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(eq2.GetPerimeter(), 2));
        }
    }
}