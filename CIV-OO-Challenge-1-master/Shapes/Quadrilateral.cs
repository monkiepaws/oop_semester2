using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Quadrilateral : Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }
        public int Side4Length { get; set; }

        public Quadrilateral(string colour, int side1Length, int side2Length, int side3Length, int side4Length) : base(colour)
        {
            this.Side1Length = side1Length;
            this.Side2Length = side2Length;
            this.Side3Length = side3Length;
            this.Side4Length = side4Length;
        }

        public int GetPerimeter()
        {
            return this.Side1Length + this.Side2Length + this.Side3Length + this.Side4Length;
        }
    }
}
