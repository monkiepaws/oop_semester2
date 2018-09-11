using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaceDemo.Tests.Mocks
{
    public class MockIShape : IShape
    {
        public string EchoInput(string pInput)
        {
            throw new NotImplementedException();
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
