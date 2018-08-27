using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class InvalidMenuOptionException : Exception
    {
        public InvalidMenuOptionException() : base("Not a valid menu option, try again\n")
        {

        }
    }
}
