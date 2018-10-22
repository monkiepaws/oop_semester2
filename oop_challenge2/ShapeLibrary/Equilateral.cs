using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Equilateral : Triangle, IShapeData
    {
        public Equilateral(double length)
        {
            this.Side1 = length;
            this.Side2 = length;
            this.Side3 = length;
        }
        public double GetArea()
        {
            double area = (Math.Sqrt(3) / 4) * (this.Side1 * this.Side1);
            return Math.Round(area, 2);
        }

        public double GetPerimeter()
        {
            return this.Side1 + this.Side2 + this.Side3;
        }

        public override string ToString()
        {
            return $"*** Equilateral Triangle ***\n" +
                   $"Colour:        {this.Colour}\n" +
                   $"Sides: {this.Side1} x {this.Side2} x {this.Side3}";
        }
    }
}
