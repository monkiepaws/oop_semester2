using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeInterfaceDemo;

namespace InterfaceDemoUI
{
    public class Triangle : IShape
    {
        double SideLength { get; set; }

        public Triangle(double sideLength)
        {
            SideLength = sideLength;
        }

        public string EchoInput(string pInput)
        {
            return $"Triangle: {pInput}";
        }

        public double GetArea()
        {
            return (Math.Sqrt(3) / 4) * (SideLength * SideLength);
        }

        public double GetPerimeter()
        {
            return SideLength * 3;
        }
    }
}
