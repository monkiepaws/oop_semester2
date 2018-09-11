using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeInterfaceDemo;

namespace InterfaceDemoUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager sm = new ShapeManager();

            string input = "none";
            int numberOfShapes = 0;

            do
            {
                Console.WriteLine("1. Create a square\n" +
                                  "2. Create an equilateral triangle");
                input = Console.ReadLine();

                if (input == "1")
                {
                    sm.AddShape(new Square(5));
                    numberOfShapes++;
                }
                else if (input == "2")
                {
                    sm.AddShape(new Triangle(6));
                    numberOfShapes++;
                }   
            }
            while (numberOfShapes < 2);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine(sm.GetFirstShape().EchoInput("Yeah"));
            Console.WriteLine(sm.GetLastShape().EchoInput("Ooohhhh, yeaahhh"));

            Console.ReadLine();
        }
    }
}
