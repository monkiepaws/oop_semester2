using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(string colour, int sideLength) : base(colour, sideLength, sideLength)
        {
            this.Side3Length = sideLength;
        }

        public double GetArea()
        {
            return Math.Round(((Math.Sqrt(3) / 4) * (this.Side1Length * this.Side1Length)), 2);
        }

        public override string ToString()
        {
            string triangle = $"--Right Angle Triangle--\n" +
                                $"Colour:       {this.Colour}\n" +
                                $"Sides:        {this.Side1Length} x {this.Side2Length} + {this.Side3Length}\n" +
                                $"Perimeter:    {this.GetPerimeter()}\n" +
                                $"Area:         {this.GetArea()}\n";

            return triangle;
        }
    }
}
