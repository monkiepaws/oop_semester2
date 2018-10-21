using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppUILibrary
{
    public class Menu
    {
        public List<IMenu> MenuItems;

        public Menu(List<IMenu> menuItems)
        {
            this.MenuItems = menuItems;
        }

        public void Play(int selection)
        {
            IMenu menu = MenuItems[selection];
            menu.Play();
        }

        public string Title(IMenu menu)
        {
            return menu.Title();
        }

        public string Instruction(IMenu menu)
        {
            return menu.Instruction();
        }
    }
}
