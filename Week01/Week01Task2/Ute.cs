using System.Drawing;

namespace Week01Task2
{
    public class Ute : Car
    {
        private int CarryLimit { get; set; }
        private int Load { get; set; }

        public Ute(string make, string model, Color colour, int wheels, string rego, int carryLimit, int load = 0)
            : base(make, model, colour, wheels, rego)
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

        public override string ToString()
        {
            return $"Make:           {this.Make}\n" +
                   $"Model:          {this.Model}\n" +
                   $"Colour:         {this.Colour}\n" +
                   $"Wheels:         {this.Wheels}\n" +
                   $"Rego:           {this.Rego}\n" +
                   $"CarryLimit:     {this.CarryLimit}\n" +
                   $"Load:           {this.Load}\n";
        }
    }
}