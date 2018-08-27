using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSystem
{
    public class Staff : Person
    {
        public string Username;

        public Staff(string fName, string sName, int yearOfBirth, string username) : base(fName, sName, yearOfBirth)
        {
            this.Username = username;
        }

        public string GetInfo()
        {
            return $"FName: {this.FName}, SName: {this.SName}, YearOfBirth: {this.YearOfBirth}, Username: {this.Username}";
        }
    }
}
