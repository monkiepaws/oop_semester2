﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShapeData> shapes = new List<IShapeData>();

            MainMenu mainMenu = new MainMenu();
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine(mainMenu.Contents());
                int option = mainMenu.Choice();

                if (option == 1)
                {
                    ShapeMenu shapeMenu = new ShapeMenu();
                    IShapeData newShape = shapeMenu.Create();
                    shapes.Add(newShape);
                }
                else if (option == 2)
                {
                    ViewShapeMenu view = new ViewShapeMenu();
                    view.DisplayShapes(shapes);
                    view.ChooseShape(shapes);
                }
                else if (option == 0)
                {
                    exit = true;
                }
            }
            while (exit == false);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
