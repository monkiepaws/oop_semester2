using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccountLibrary
{
    public interface IWithdraw
    {
        bool Withdraw(decimal amount);
    }
}
