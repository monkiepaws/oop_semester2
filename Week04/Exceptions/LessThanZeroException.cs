using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [Serializable]
    class LessThanZeroException : Exception
    {
        public LessThanZeroException()
        {

        }

        public LessThanZeroException(string input) : base($"{input} is less than zero")
        {

        }
    }
}
