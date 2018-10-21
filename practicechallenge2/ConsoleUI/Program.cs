using BankAppUILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMenu> menus = new List<IMenu>();
            menus.Add(new CreateAccountMenu());

            Menu menu = new Menu(menus);

            Console.ReadLine();
        }
    }
}
