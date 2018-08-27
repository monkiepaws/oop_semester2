using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            bool exit = false;
            int option = -1;

            while (exit == false)
            {
                option = MainMenu();
                if (option == 0)
                {
                    PrintShapes(shapes);
                    exit = true;
                }
                else if (option == 5)
                {
                    ViewShapes(shapes);
                }
                else
                {
                    Shape newShape = CreateShape(option);
                    shapes.Add(newShape);
                }

                Console.WriteLine("\nPress enter to continue...");
                Console.ReadLine();
            }
        }

        static void PrintShapes(List<Shape> shapes)
        {
            Console.Clear();
            Console.WriteLine("** Shapes you created **");

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("************************");
        }

        static int MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("****** Create Shapes Menu ******\n" +
                                    "1. Create Square\n" +
                                    "2. Create Rectangle\n" +
                                    "3. Create Right Angle Triangle\n" +
                                    "4. Create Equilateral Triangle\n" +
                                    "5. View Shapes\n" +
                                    "0. Exit\n");
                Console.WriteLine("Enter a number to proceed:");

                try
                {
                    int input = int.Parse(Console.ReadLine());

                    if (IsValidMenuOption(input) == true)
                    {
                        return input;
                    }
                    else
                    {
                        throw new InvalidMenuOptionException();
                    }

                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"Menu option should be a digit\n{exception}");
                    Console.ReadLine();
                }
                catch (InvalidMenuOptionException exception)
                {
                    Console.WriteLine(exception);
                    Console.ReadLine();
                }
            }
        }

        static bool IsValidMenuOption(int input)
        {
            switch (input)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 0:
                    return true;
                default:
                    return false;
            }
        }

        static Shape CreateShape(int option)
        {
            switch (option)
            {
                case 1:
                    return CreateSquare();
                case 2:
                    return CreateRectangle();
                case 3:
                    return CreateRightAngleTriangle();
                case 4:
                    return CreateEquilateralTriangle();
                default:
                    throw new Exception();
            }
        }

        static void ViewShapes(List<Shape> shapes)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("** View Shapes **");

                int counter = 1;

                foreach (Shape s in shapes)
                {
                    Console.WriteLine($"{counter}. {s.GetType()}");
                    counter++;
                }

                Console.WriteLine("0. Exit");
                Console.WriteLine("Please enter a number to view the details of that shape: ");

                try
                {
                    int input = int.Parse(Console.ReadLine());

                    if (input == 0)
                    {
                        return;
                    }
                    
                    if (input > 0)
                    {
                        Console.WriteLine($"\n{shapes[input - 1].ToString()}\n");
                        Console.WriteLine("Press enter to continue...");

                        Console.ReadLine();
                    }
                    else
                    {
                        throw new InvalidMenuOptionException();
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"Please only enter a number\n{exception}");
                }
                catch (InvalidMenuOptionException exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        static Shape CreateSquare()
        {
            Console.WriteLine("-- Create Square --");
            Console.WriteLine("Enter a colour: ");
            string colour = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter the side length:");

                try
                {
                    int input = int.Parse(Console.ReadLine());

                    if (input < 1)
                    {
                        throw new InvalidSideLengthException();
                    }
                    else
                    {
                        Square newSquare = new Square(colour, input);
                        Console.WriteLine($"Created new Square coloured {colour} with side length {input}");

                        return newSquare;
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"Side length must be an integer digit\n{exception}");
                }
                catch (InvalidSideLengthException exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        static Shape CreateRectangle()
        {
            Console.WriteLine("-- Create Rectangle --");
            Console.WriteLine("Enter a colour: ");
            string colour = Console.ReadLine();

            int validSides = 0;
            int side1Length = 0;
            int side2Length = 0;

            while (true)
            {
                if (validSides < 1)
                {
                    Console.WriteLine("Enter the first side length:");
                }
                else
                {
                    Console.WriteLine("Enter the second side length:");
                }

                try
                {
                    int input = int.Parse(Console.ReadLine());

                    if (input < 1)
                    {
                        throw new InvalidSideLengthException();
                    }
                    else
                    {
                        if (validSides < 1)
                        {
                            side1Length = input;
                            validSides++;
                        }
                        else
                        {
                            side2Length = input;
                            Rectangle newRectangle = new Rectangle(colour, side1Length, side2Length);
                            Console.WriteLine($"Created new Rectangle coloured {colour} with lengths {side1Length} x {side2Length}");

                            return newRectangle;
                        }

                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"Side length must be an integer digit\n{exception}");
                }
                catch (InvalidSideLengthException exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        static Shape CreateEquilateralTriangle()
        {
            Console.WriteLine("-- Create Equilateral Triangle --");
            Console.WriteLine("Enter a colour: ");
            string colour = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter the side length:");

                try
                {
                    int input = int.Parse(Console.ReadLine());

                    if (input < 1)
                    {
                        throw new InvalidSideLengthException();
                    }
                    else
                    {
                        EquilateralTriangle newEquilateralTriangle = new EquilateralTriangle(colour, input);
                        Console.WriteLine($"Created new Equilateral Triangle coloured {colour} with sides {newEquilateralTriangle.Side1Length} x {newEquilateralTriangle.Side2Length} x {newEquilateralTriangle.Side3Length}");

                        return newEquilateralTriangle;
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"Side length must be an integer digit\n{exception}");
                }
                catch (InvalidSideLengthException exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        static Shape CreateRightAngleTriangle()
        {
            Console.WriteLine("-- Create Right Angled Triangle --");
            Console.WriteLine("Enter a colour: ");
            string colour = Console.ReadLine();

            int validSides = 0;
            int side1Length = 0;
            int side2Length = 0;

            while (true)
            {
                if (validSides < 1)
                {
                    Console.WriteLine("Enter the first side length:");
                }
                else
                {
                    Console.WriteLine("Enter the second side length:");
                }

                try
                {
                    int input = int.Parse(Console.ReadLine());

                    if (input < 1)
                    {
                        throw new InvalidSideLengthException();
                    }
                    else
                    {
                        if (validSides < 1)
                        {
                            side1Length = input;
                            validSides++;
                        }
                        else
                        {
                            side2Length = input;
                            RightAngleTriangle newRightAngleTriangle = new RightAngleTriangle(colour, side1Length, side2Length);
                            Console.WriteLine($"Created new Right Angle Triangle coloured {colour} with lengths {side1Length} x {side2Length} x {Math.Round(newRightAngleTriangle.Side3Length), 2}");

                            return newRightAngleTriangle;
                        }

                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"Side length must be an integer digit\n{exception}");
                }
                catch (InvalidSideLengthException exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }
    }
}
