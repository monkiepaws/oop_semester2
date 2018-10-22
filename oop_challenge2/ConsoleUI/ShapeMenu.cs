using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;

namespace ConsoleUI
{
    public class ShapeMenu
    {
        public Shape Create()
        {
            Console.WriteLine(this.Content());

            while (true)
            {
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        return CreateSquare();
                    //case "2":
                    //    return CreateRectangle();
                    //case "3":
                    //    return CreateEquilateral();
                    //case "4":
                    //    return CreateRightAngle();
                    //case "5":
                    //    return CreateCircle();
                    default:
                        Console.WriteLine("Please enter a valid option, try again:");
                        break;
                }
            }

        }
        public string Content()
        {
            return $"--- Create Shape Menu ---\n" +
                   $"1. New Square\n" +
                   $"2. New Rectangle\n" +
                   $"3. New Equilateral Triangle\n" +
                   $"4. New Right Angled Triangle\n" +
                   $"5. Circle\n" +
                   $"-------------------------\n" +
                   $"\n" +
                   $"Enter an option:\n";
        }

        public Shape CreateSquare()
        {
            Console.Clear();
            Console.WriteLine($"--- New Square ---\n" +
                              $"Enter colour: \n");
            string colour = Console.ReadLine();

            Console.WriteLine($"Enter Side1 Length: ");
            bool isValidInput = false;

            while (isValidInput == false)
            {
                try
                {
                    int length = 0;
                    isValidInput = int.TryParse(Console.ReadLine(), out length);

                    if (isValidInput == true)
                    {
                        if (length >= 1)
                        {
                            Square square = new Square(length);
                            square.Colour = colour;
                            return square;
                        }
                        else
                        {
                            isValidInput = false;
                            throw new InvalidSideLengthException();
                        }
                    }
                    else
                    {
                        isValidInput = false;
                        throw new InvalidSideLengthIntegerException();
                    }
                }
                catch (InvalidSideLengthException e)
                {
                    Console.WriteLine(e);
                }
                catch (InvalidSideLengthIntegerException e)
                {
                    Console.WriteLine(e);
                }
            }
            return null;
        }

        public Shape CreateRectangle()
        {
            Console.Clear();
            Console.WriteLine($"--- New Square ---\n" +
                              $"Enter colour: \n");
            string colour = Console.ReadLine();

            Console.WriteLine($"Enter Side1 Length: ");
            int side1 = 0;
            bool isValidInput = false;

            while (isValidInput == false)
            {
                try
                {
                    isValidInput = int.TryParse(Console.ReadLine(), out side1);

                    if (isValidInput == true)
                    {
                        if (side1 < 1)
                        {
                            throw new InvalidSideLengthException();
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        throw new InvalidSideLengthIntegerException();
                    }
                }
                catch (InvalidSideLengthException e)
                {
                    Console.WriteLine(e);
                }
                catch (InvalidSideLengthIntegerException e)
                {
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine($"Enter Side2 Length: ");
            int side2 = 0;
            isValidInput = false;

            while (isValidInput == false)
            {
                try
                {
                    isValidInput = int.TryParse(Console.ReadLine(), out side2);

                    if (isValidInput == true)
                    {
                        if (side2 < 1)
                        {
                            throw new InvalidSideLengthException();
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        throw new InvalidSideLengthIntegerException();
                    }
                }
                catch (InvalidSideLengthException e)
                {
                    Console.WriteLine(e);
                }
                catch (InvalidSideLengthIntegerException e)
                {
                    Console.WriteLine(e);
                }
            }

            Rectangle rectangle = new Rectangle(side1, side2);
            rectangle.Colour = colour;

            return rectangle;
        }
    }
}
