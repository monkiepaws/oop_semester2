using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankingAccountLibrary
{
    public class CreditAccount: IDeposit, IWithdraw, IBalance, IPin
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal WithdrawalFee { get; set; }

        public CreditAccount(StandardAccountDetails details)
        {
            try
            {
                if (IsValidPin(details.pin) == true)
                {
                    this.AccountNumber = details.accountNumber;
                    this.CustomerName = details.customerName;
                    this.Pin = details.pin;
                    this.Balance = details.balance;
                    this.CreditLimit = -2000;
                    this.WithdrawalFee = 0.01m;
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
            decimal amountWithFee = amount + Math.Floor(((amount * WithdrawalFee) * 100) / 100);

            if (this.Balance - amountWithFee > this.CreditLimit)
            {
                this.Balance -= amountWithFee;
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal GetBalance()
        {
            return this.Balance;
        }

        public decimal BalanceInOneYear()
        {
            if (this.Balance >= 0)
            {
                return this.Balance;
            }
            else
            {
                decimal interest = Math.Floor((this.Balance * 0.1m) * 100) / 100;
                decimal result = this.Balance + interest;

                return result;
            }
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
