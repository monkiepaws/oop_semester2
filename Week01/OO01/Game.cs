using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO01
{
    class Game
    {
        public string Name;

        public int Rating;

        private List<int> Reviews;

        public double Price;

        public string Desc;

        public string Genre;

        public Game(string name, double price, string desc, string genre)
        {
            this.Name = name;
            this.Price = price;
            this.Desc = desc;
            this.Genre = genre;

            this.Reviews = new List<int>();
        }

        public void ReviewGame(int rating)
        {
            Reviews.Add(rating);

            Rating = Convert.ToInt32(Reviews.Average());
        }
    }
}
