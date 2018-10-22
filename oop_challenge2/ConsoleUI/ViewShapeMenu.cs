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
        public void DisplayShapes(List<IShapeData> shapes)
        {
            Console.Clear();
            Console.WriteLine("--- Shapes on file: ---");

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {shapes[i].GetType()}");
            }
        }

        public void ChooseShape(List<IShapeData> shapes)
        {
            bool isValidInput = false;
            int selection = 0;

            while (isValidInput == false)
            {
                string input = Console.ReadLine();
                bool isInteger = int.TryParse(input, out selection);

                if (isInteger == true && shapes.ElementAt(selection- 1) != null)
                {
                    selection--;
                    IShapeData selectedShape = shapes[selection];
                    Display(selectedShape);
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid option, try again:");
                }
            }   
        }

        public void Display(IShapeData shape)
        {
            IShapeData shapeData = (IShapeData)shape;

            Console.WriteLine(shape.ToString());
            Console.WriteLine();

            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("1. Get Area\n" +
                  "2. Get Perimeter\n" +
                  "-\n" +
                  "0. Exit");
                Console.WriteLine("Enter an option: ");
                string input = Console.ReadLine();
                
                switch(input)
                {
                    case "1":
                        GetArea(shape);
                        break;
                    case "2":
                        GetPerimeter(shape);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Enter a valid option, try again: ");
                        break;
                }
            }
        }

        public void GetArea(IShapeData shape)
        {
            Console.WriteLine($"Area = {shape.GetArea()}\n");
        }

        public void GetPerimeter(IShapeData shape)
        {
            Console.WriteLine($"Perimeter = {shape.GetPerimeter()}\n");
        }
    }
}
