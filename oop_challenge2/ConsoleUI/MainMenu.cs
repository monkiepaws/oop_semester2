using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MainMenu
    {
        public string Contents()
        {
            //return $"--- Shapes Main Menu ---" +
            //       $"1. Create Square" +
            //       $"2. Create Rectangle" +
            //       $"3. Create Equilateral Triangle" +
            //       $"4. Create Right Angled Triangle" +
            //       $"5. Create Circle" +
            //       $"-" +
            //       $"6. View Created Shapes" +
            //       $"-" +
            //       $"0. Exit" +
            //       $"------------------------" +
            //       $"" +
            //       $"Enter a number to proceed:";
            return $"--- Shapes Main Menu ---\n" +
                   $"1. Create new Shape\n" +
                   $"2. View created Shapes\n" +
                   $"-\n" +
                   $"0. Exit\n" +
                   $"------------------------\n" +
                   $"\n" +
                   $"Enter a number to proceed:\n";
        }

        public int Choice()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "1" || input == "2" || input == "0")
                {
                    return int.Parse(input);
                }
                else
                {
                    Console.WriteLine("You must enter a valid option, try again:");
                }
            }
        }
    }
}
