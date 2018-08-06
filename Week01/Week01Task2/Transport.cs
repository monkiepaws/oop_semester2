using System.Drawing;

namespace Week01Task2
{
    public abstract class Transport
    {
        internal string Make { get; private set; }
        internal string Model { get; private set; }
        internal Color Colour { get; private set; }

        protected Transport(string make, string model, Color colour)
        {
            this.Make = make;
            this.Model = model;
            this.Colour = new Color();
            this.Colour = colour;
        }
    }
}