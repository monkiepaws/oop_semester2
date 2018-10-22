using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Rectangle : Quadrilateral, IShapeData
    {
        public Rectangle(double length, double width)
        {
            this.Side1 = length;
            this.Side2 = width;
            this.Side3 = length;
            this.Side4 = width;
        }
        public double GetArea()
        {
            return this.Side1 * this.Side2;
        }

        public double GetPerimeter()
        {
            return this.Side1 + this.Side2 + this.Side3 + this.Side4;
        }

        public override string ToString()
        {
            return $"*** Rectangle ***\n" +
                   $"Colour:        {this.Colour}\n" +
                   $"Sides: {this.Side1} x {this.Side2} x {this.Side3} x {this.Side4}";
        }
    }
}
