using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaceDemo
{
    public class ShapeManager
    {
        public List<IShape> ShapeList = new List<IShape>();

        public void AddShape(IShape shape)
        {
            ShapeList.Add(shape);
        }

        public IShape GetFirstShape()
        {
            return ShapeList.First();
        }

        public IShape GetLastShape()
        {
            return ShapeList.Last();
        }
    }
}
