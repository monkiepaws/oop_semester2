using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class WelcomeMenu
    {
        public static void StartMenu()
        {
            string input = "";

            while (input != "5")
            {
                ShowWelcomeMenu();
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        this.CreateStudentMenu();
                        break;
                    case "2":
                        this.CreateTeacherMenu();
                        break;
                    case "3":
                        this.CreateAdminMenu();
                        break;
                    case "4":
                        this.ViewPeopleMenu();
                        break;
                    default:
                        Console.WriteLine("Not a valid menu input, try again:");
                        break;
                }
            }
        }

        public static void ShowWelcomeMenu()
        {
            Console.Clear();
            Console.WriteLine
            (
                "Welcome-\n" +
                "1. Create Student\n" +
                "2. Create Teacher\n" +
                "3. Create Admin\n" +
                "4. View People\n" +
                "5. Exit\n"
            );
        }
    }
}
