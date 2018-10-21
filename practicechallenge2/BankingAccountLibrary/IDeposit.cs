using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccountLibrary
{
    public interface IDeposit
    {
        bool Deposit(decimal amount);
    }
}
