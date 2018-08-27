using AdminSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class CreateMenu
    {
        public static Student CreateStudent()
        {
            Student newStudent = (Student)CreatePerson();

            bool isValidId = false;
            int id = 0;

            while (isValidId == false)
            {
                Console.WriteLine("Enter ID:");

                try
                {
                    id = int.Parse(Console.ReadLine());
                    isValidId = true;
                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"ID must be an integer\n{exception}");
                }
            }

            return newStudent;
        }
        public static Person CreatePerson()
        {
            Console.WriteLine();
            Console.WriteLine("Create Student-");
            Console.WriteLine("Enter FirstName:");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Surname:");
            string sName = Console.ReadLine();

            bool isValidYearOfBirth = false;
            int yearOfBirth = 0;

            while (isValidYearOfBirth == false)
            {
                Console.WriteLine("Enter Year of Birth:");

                try
                {
                    yearOfBirth = int.Parse(Console.ReadLine());

                    if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
                    {
                        throw new InvalidYearOfBirthException();
                    }
                    else
                    {
                        isValidYearOfBirth = true;
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"YearOfBirth must be a 4-digit year between 1900-{DateTime.Now.Year}\n{exception}");
                }
                catch (InvalidYearOfBirthException exception)
                {
                    Console.WriteLine(exception);
                }
            }

            Person newPerson = new Person(fName, sName, yearOfBirth);

            return newPerson;
        }
    }
}
