using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string colour, int side1Length, int side2Length) : base(colour, side1Length, side2Length, side1Length, side2Length)
        {

        }
        public int GetArea()
        {
            return this.Side1Length * this.Side2Length;
        }

        public override string ToString()
        {
            string rectangle = $"--Rectangle--\n" +
                                $"Colour:       {this.Colour}\n" +
                                $"Sides:        {this.Side1Length} x {this.Side2Length} x {this.Side3Length} x {this.Side4Length}\n" +
                                $"Perimeter:    {this.GetPerimeter()}\n" +
                                $"Area:         {this.GetArea()}\n";

            return rectangle;
        }
    }
}
