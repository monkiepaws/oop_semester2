using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSystem
{
    public class Student : Person
    {
        public int Id;

        public Student(string fName, string sName, int yearOfBirth, int id) : base(fName, sName, yearOfBirth)
        {
            this.Id = id;
        }

        public string GetInfo()
        {
            return $"FName: {this.FName}, SName: {this.SName}, YearOfBirth: {this.YearOfBirth}, Id: {this.Id}";
        }
    }
}
