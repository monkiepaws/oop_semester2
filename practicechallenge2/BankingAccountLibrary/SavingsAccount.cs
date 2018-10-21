using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankingAccountLibrary
{
    public class SavingsAccount : IDeposit, IWithdraw, IBalance, IPin
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }

        public SavingsAccount(StandardAccountDetails details)
        {
            try
            {
                if (IsValidPin(details.pin) == true)
                {
                    this.AccountNumber = details.accountNumber;
                    this.CustomerName = details.customerName;
                    this.Pin = details.pin;
                    this.Balance = details.balance;
                }
                else
                {
                    throw new ArgumentException("PIN number not valid");
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception);
            }
        }

        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || (amount > this.Balance))
            {
                return false;
            }
            else
            {
                this.Balance -= amount;
                return true;
            }
        }

        public decimal GetBalance()
        {
            return this.Balance;
        }

        public decimal BalanceInOneYear()
        {
            decimal interest = Math.Floor((this.Balance * 0.02m) * 100) / 100;
            decimal result = this.Balance + interest;

            return result;
        }

        public bool IsValidPin(string pin)
        {
            // This regular expression matches only strings with digits 0-9
            Regex regex = new Regex(@"^[0-9]+$");

            if (pin.Length == 6 && regex.IsMatch(pin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
