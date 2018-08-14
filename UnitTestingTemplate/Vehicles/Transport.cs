using System.Drawing;

namespace Vehicles
{
    public class Transport
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Color Colour { get; set; }

        public Transport(string make, string model, Color colour)
        {
            this.Make = make;
            this.Model = model;
            this.Colour = colour;
        }
    }
}