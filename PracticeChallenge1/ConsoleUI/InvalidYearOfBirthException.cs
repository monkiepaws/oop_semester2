using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class InvalidYearOfBirthException : Exception
    {
        public InvalidYearOfBirthException() : base($"YearOfBirth was not between 1900 and {DateTime.Now.Year}")
        {

        }
    }
}
