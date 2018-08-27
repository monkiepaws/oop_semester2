using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class RightAngleTriangle : Triangle
    {
        public RightAngleTriangle(string colour, int side1Length, int side2Length) : base(colour, side1Length, side2Length)
        {
            this.Side3Length = Math.Sqrt((side1Length * side1Length) + (side2Length * side2Length));
        }

        public double GetArea()
        {
            return Math.Round((0.5 * this.Side1Length * this.Side2Length), 2);
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
