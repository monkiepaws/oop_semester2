using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [Serializable]
    class GreaterThanFifteenException : Exception
    {
        public GreaterThanFifteenException()
        {

        }
        public GreaterThanFifteenException(string input) : base($"{input} is greater than 15")
        {

        }
    }
}
