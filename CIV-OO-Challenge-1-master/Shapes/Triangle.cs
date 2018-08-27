using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public double Side3Length { get; set; }

        public Triangle(string colour, int side1Length, int side2Length) : base(colour)
        {
            this.Side1Length = side1Length;
            this.Side2Length = side2Length;
        }

        public double GetPerimeter()
        {
            return this.Side1Length + this.Side2Length + this.Side3Length;
        }
    }
}
