using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Square : Quadrilateral, IShapeData
    {
        public Square(double length)
        {
            this.Side1 = length;
            this.Side2 = length;
            this.Side3 = length;
            this.Side4 = length;
        }
        public double GetArea()
        {
            return this.Side1 * this.Side1;
        }

        public double GetPerimeter()
        {
            return this.Side1 + this.Side2 + this.Side3 + this.Side4;
        }
    }
}
