using System.Drawing;

namespace Vehicles
{
    public class Ute : Car
    {
        public int CarryLimit { get; set; }
        public int Load { get; set; }

        public Ute(string make, string model, Color colour, int wheels, string rego, int carryLimit, int load) :
            base(make, model, colour, wheels, rego)
        {
            this.CarryLimit = carryLimit;
            this.Load = load;
        }

        public bool AddLoad(int loadToAdd)
        {
            if (this.Load + loadToAdd > this.CarryLimit)
            {
                return false;
            }

            this.Load += loadToAdd;
            return true;
        }
    }
}