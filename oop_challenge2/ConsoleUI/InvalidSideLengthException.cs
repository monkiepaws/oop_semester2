using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class InvalidSideLengthException : Exception
    {
        public InvalidSideLengthException() : base("Side length must be at least 1, try again\n")
        {

        }
    }
}
