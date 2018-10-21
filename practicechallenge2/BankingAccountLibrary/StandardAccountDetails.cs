using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccountLibrary
{
    public struct StandardAccountDetails
    {
        public string accountNumber;
        public string customerName;
        public string pin;
        public decimal balance;

        public StandardAccountDetails(string accountNumber, string customerName, string pin, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.pin = pin;
            this.balance = balance;
        }
    }
}
