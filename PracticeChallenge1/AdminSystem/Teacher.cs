using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSystem
{
    public class Teacher : Staff
    {
        public string Expertise;

        public Teacher(string fName, string sName, int yearOfBirth, string username, string expertise) : base(fName, sName, yearOfBirth, username)
        {
            this.Expertise = expertise;
        }

        public new string GetInfo()
        {
            return $"FName: {this.FName}, SName: {this.SName}, YearOfBirth: {this.YearOfBirth}, Username: {this.Username}, Expertise: {this.Expertise}";
        }
    }
}
