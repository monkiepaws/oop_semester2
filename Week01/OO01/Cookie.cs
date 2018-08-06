using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO01
{
    class Cookie
    {
        public string Name { get; private set; }
        public string Shape { get; private set; }
        public string Colour { get; private set; }
        public string Topping { get; private set; }
        public DateTime DateBaked { get; private set; }
        private TimeSpan ShelfLife = new TimeSpan(4, 0, 0, 0);

        public Cookie(string name, string shape, string colour, string topping, DateTime dateBaked)
        {
            this.Name = name;
            this.Shape = shape;
            this.Colour = colour;
            this.Topping = topping;
            this.DateBaked = dateBaked;
        }

        public void ChangeTopping(string topping)
        {
            Topping = topping;
        }
        
        public bool IsOutOfDate()
        {
            if (DateBaked.Date < (DateTime.Now.Date - ShelfLife))
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"** {Name} **\n" +
                $"Shape: {Shape}\n" +
                $"Topping: {Topping}\n" +
                $"Baked on: {DateBaked}";
        }
    }
}
