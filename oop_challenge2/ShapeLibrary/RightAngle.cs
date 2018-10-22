using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class RightAngle : Triangle, IShapeData
    {
        public RightAngle(double side1Length, double side2Length)
        {
            this.Side1 = side1Length;
            this.Side2 = side2Length;
            this.Side3 = GetHypotenuse();
        }
        public double GetHypotenuse()
        {
            return Math.Sqrt((Side1 * Side1) + (Side2 * Side2));
        }
        public double GetArea()
        {
            return Math.Round((0.5 * this.Side1 * this.Side2), 2);
        }

        public double GetPerimeter()
        {
            double perimeter = this.Side1 + this.Side2 + this.Side3;
            return Math.Round(perimeter, 2);
        }
    }
}
