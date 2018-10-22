using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Circle : Shape, IShapeData
    {
        public readonly double PI = Math.PI;
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            double area = this.PI * (this.Radius * this.Radius);
            return Math.Round(area, 2);
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * this.PI * this.Radius;
            return Math.Round(perimeter, 2);
        }
    }
}
