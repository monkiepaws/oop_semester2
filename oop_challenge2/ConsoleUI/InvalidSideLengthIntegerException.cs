using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class InvalidSideLengthIntegerException : Exception
    {
        public InvalidSideLengthIntegerException() : base("Side length must be an integer, try again\n")
        {

        }
    }
}