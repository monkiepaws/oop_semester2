using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccountLibrary
{
    public interface IPin
    {
        string Pin { get; set; }
        bool IsValidPin(string pin);
    }
}
