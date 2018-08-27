using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSystem
{
    public class Admin : Staff
    {
        public int OfficeNo;

        public Admin(string fName, string sName, int yearOfBirth, string username, int officeNo) : base(fName, sName, yearOfBirth, username)
        {
            this.OfficeNo = officeNo;
        }

        public new string GetInfo()
        {
            return $"FName: {this.FName}, SName: {this.SName}, YearOfBirth: {this.YearOfBirth}, Username: {this.Username}, OfficeNo: {this.OfficeNo}";
        }
    }
}
