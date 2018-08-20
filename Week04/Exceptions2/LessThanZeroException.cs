using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    [Serializable]
    class LessThanZeroException : Exception
    {
        public LessThanZeroException()
        {

        }

        public LessThanZeroException(int number) : base($"{number} is less than zero")
        {

        }
    }
}
