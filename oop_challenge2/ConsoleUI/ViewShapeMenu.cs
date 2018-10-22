using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;

namespace ConsoleUI
{
    public class ViewShapeMenu
    {
        public void DisplayShapes(List<Shape> shapes)
        {
            Console.Clear();
            Console.WriteLine("--- Shapes on file: ---");
            int counter = 1;

            foreach (Shape s in shapes)
            {
                Console.WriteLine($"{counter}. {s.GetType()}");
            }
        }
    }
}
