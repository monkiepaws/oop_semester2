using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO01
{
    class Animal
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public int LegCount { get; set; }
        public int Age { get; set; }

        public Animal(string name, string ownerName, int age, int legCount)
        {
            this.Name = name;
            this.OwnerName = ownerName;
            this.Age = age;
            this.LegCount = legCount;
        }
    }

    class Cat : Animal
    {
        public int Lives { get; private set; }

        public Cat(string name, string ownerName, int age) : base(name, ownerName, age, 4)
        {
            this.Lives = 9;
        }

        public void KillCat()
        {
            Lives--;
        }

        public bool TryKillCat()
        {
            if (Lives > 0)
            {
                Lives--;
                return true;
            }

            return false;
        }
    }
}
