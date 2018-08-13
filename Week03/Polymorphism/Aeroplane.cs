using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Aeroplane : Transport
    {
        public int WingSpan { get; set; }

        public Aeroplane(string make, string model, Color colour, int passengerLimit, int passengers, int wingSpan) : base(make, model, colour, passengerLimit, passengers)
        {
            this.WingSpan = wingSpan;
        }

        public string Fly()
        {
            return "Whoooosh!";
        }
    }
}
