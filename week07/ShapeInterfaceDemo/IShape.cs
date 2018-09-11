﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaceDemo
{
    public interface IShape
    {
        double GetPerimeter();
        double GetArea();
        string EchoInput(string pInput);
    }
}
