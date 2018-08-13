using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Ute : Car
    {
        public int CarryLimit { get; set; }
        public int Load { get; set; }

        public Ute(string make, string model, Color colour, int passengerLimit, int passengers, int wheels, string rego, int carryLimit, int load) : 
            base(make, model, colour, passengerLimit, passengers, wheels, rego)
        {
            this.CarryLimit = carryLimit;
            this.Load = load;
        }

        public bool AddLoad(int loadToAdd)
        {
            if (Load + loadToAdd > CarryLimit)
            {
                return false;
            }

            Load += loadToAdd;
            return true;
        }
    }
}
