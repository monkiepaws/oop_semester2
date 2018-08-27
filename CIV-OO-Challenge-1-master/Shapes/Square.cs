using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Quadrilateral
    {
        public Square(string colour, int sideLength) : base(colour, sideLength, sideLength, sideLength, sideLength)
        {
            
        }
        public int GetArea()
        {
            return this.Side1Length * this.Side1Length;
        }

        public override string ToString()
        {
            string square = $"--Square--\n" +
                            $"Colour:       {this.Colour}\n" +
                            $"Sides:        {this.Side1Length} x {this.Side2Length} x {this.Side3Length} x {this.Side4Length}\n" +
                            $"Perimeter:    {this.GetPerimeter()}\n" +
                            $"Area:         {this.GetArea()}\n";

            return square;
        }
    }
}
