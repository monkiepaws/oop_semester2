using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class SailBoat : Boat
    {
        public int NumberOfSails { get; set; }
        public bool AreSailsOpen { get; set; }
        public bool Motor { get; set; }

        public SailBoat(string make, string model, Color colour, int passengerLimit, int passengers, int hullLength, string callSign, string hullMaterial, int numberOfSails, bool areSailsOpen = false, bool motor = false) : 
            base(make, model, colour, passengerLimit, passengers, hullLength, callSign, hullMaterial)
        {
            this.NumberOfSails = numberOfSails;
            this.AreSailsOpen = areSailsOpen;
            this.Motor = motor;
        }
        
        public void OpenSails()
        {
            AreSailsOpen = true;
        }

        public void CloseSails()
        {
            AreSailsOpen = false;
        }
    }
}
