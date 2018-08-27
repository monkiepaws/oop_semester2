using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSystem
{
    public class Person
    {
        public string FName;
        public string SName;
        public int YearOfBirth;

        public Person(string fName, string sName, int yearOfBirth)
        {
            this.FName = fName;
            this.SName = sName;
            this.YearOfBirth = yearOfBirth;
        }

        public string GetName()
        {
            return $"{this.FName} {this.SName}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.YearOfBirth;
        }
    }
}
