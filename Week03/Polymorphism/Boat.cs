using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Boat : Transport
    {
        public int HullLength { get; set; }
        public string CallSign { get; set; }
        public string HullMaterial { get; set; }
        public Boat(string make, string model, Color colour, int passengerLimit, int passengers, int hullLength, string callSign, string hullMaterial) : 
            base(make, model, colour, passengerLimit, passengers)
        {
            this.HullLength = hullLength;
            this.CallSign = callSign;
            this.HullMaterial = hullMaterial;
        }
    }
}
