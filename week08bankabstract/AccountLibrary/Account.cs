using System;

namespace AccountLibrary
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string PIN { get; set; }
        public decimal Balance { get; private set; }

        public Account(string accountNumber, string customerName, string pin)
        {
            this.AccountNumber = accountNumber;
            this.CustomerName = customerName;
            this.PIN = pin;
        }

        public virtual bool Deposit(decimal amount)
        {
            this.Balance += amount;
            return true;
        }

        public virtual bool Withdrawal(decimal amount)
        {
            if (this.Balance < amount)
            {
                return false;
            }
            else
            {
                this.Balance -= amount;
                return true;
            }
        }

        public abstract decimal BalanceInOneYear();
    }
}