using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BankingAccountLibrary.Tests
{
    [TestFixture]
    public class DebitAccountTests
    {
        [TestCase("123456789", "Harry Who", "987654", 6000.89)]
        [TestCase("987654321", "Barry Bob", "123456", 22)]
        [TestCase("456987123", "Larry Emerald", "147852", 198654236.88)]
        [TestCase("951753852", "Terry Terrible", "913746", 0)]
        public void DebitAccount_ValidInput_CorrectOutput(string accountNumber, string customerName, string pin, decimal balance)
        {
            // Arrange
            StandardAccountDetails details = new StandardAccountDetails(accountNumber, customerName, pin, balance);
            DebitAccount tested = new DebitAccount(details);

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(tested.AccountNumber == accountNumber);
                Assert.That(tested.CustomerName == customerName);
                Assert.That(tested.Pin == pin);
                Assert.That(tested.Balance == balance);
                Assert.That(tested.WithdrawalFee == 0.01m);
            });
        }

        [TestCase("123456789", "Harry Who", "987654", 6000.89, 0.11)]
        [TestCase("987654321", "Barry Bob", "123456", 22, 6.23)]
        [TestCase("456987123", "Larry Emerald", "147852", 198654236.88, 66666688.44)]
        [TestCase("951753852", "Terry Terrible", "913746", 0, 0.01)]
        public void Deposit_ValidInput_CorrectOutput(string accountNumber, string customerName, string pin, decimal balance, decimal depositAmount)
        {
            // Arrange
            StandardAccountDetails details = new StandardAccountDetails(accountNumber, customerName, pin, balance);
            DebitAccount tested = new DebitAccount(details);

            // Act
            tested.Deposit(depositAmount);

            // Assert
            Assert.That(tested.Balance == balance + depositAmount);
        }

        [TestCase("123456789", "Harry Who", "987654", 900.89, 500.11)]
        [TestCase("987654321", "Barry Bob", "123456", 220, 100.23)]
        [TestCase("456987123", "Larry Emerald", "147852", 1000000.88, 1900.44)]
        [TestCase("951753852", "Terry Terrible", "913746", 0.01, 0.01)]
        public void Withdraw_ValidInput_CorrectOutput(string accountNumber, string customerName, string pin, decimal balance, decimal withdrawalAmount)
        {
            // Arrange
            StandardAccountDetails details = new StandardAccountDetails(accountNumber, customerName, pin, balance);
            DebitAccount tested = new DebitAccount(details);

            // Act
            tested.Withdraw(withdrawalAmount);

            // Assert
            Assert.That(tested.Balance == (balance - withdrawalAmount - (Math.Floor((withdrawalAmount * tested.WithdrawalFee) * 100) / 100)));
        }

        [TestCase("123456789", "Harry Who", "987654", 6000.89)]
        [TestCase("987654321", "Barry Bob", "123456", 22)]
        [TestCase("456987123", "Larry Emerald", "147852", 198654236.88)]
        [TestCase("951753852", "Terry Terrible", "913746", 0)]
        public void GetBalance_ValidInput_CorrectOutput(string accountNumber, string customerName, string pin, decimal balance)
        {
            // Arrange
            StandardAccountDetails details = new StandardAccountDetails(accountNumber, customerName, pin, balance);
            DebitAccount tested = new DebitAccount(details);

            // Act
            decimal result = tested.GetBalance();

            // Assert
            Assert.That(result == balance);
        }

        [TestCase("123456789", "Harry Who", "987654", 6000.89, 6120.90)]
        [TestCase("987654321", "Barry Bob", "123456", 22, 22.44)]
        [TestCase("456987123", "Larry Emerald", "147852", 198654236.88, 202627321.61)]
        [TestCase("951753852", "Terry Terrible", "913746", 0, 0)]
        public void BalanceInOneYear_ValidInput_CorrectOutput(string accountNumber, string customerName, string pin, decimal balance, decimal expected)
        {
            // Arrange
            StandardAccountDetails details = new StandardAccountDetails(accountNumber, customerName, pin, balance);
            DebitAccount tested = new DebitAccount(details);

            // Act
            decimal result = tested.BalanceInOneYear();

            // Assert
            Assert.That(result == expected);
        }

        [TestCase("987654")]
        [TestCase("123456")]
        [TestCase("147852")]
        [TestCase("913746")]
        public void IsValidPin_ValidInput_CorrectOutput(string pin)
        {
            // Arrange
            StandardAccountDetails details = new StandardAccountDetails("123", "Harry", pin, 1);
            DebitAccount test = new DebitAccount(details);

            // Act
            bool isValidPin = test.IsValidPin(pin);

            // Assert
            Assert.That(isValidPin == true);
        }

        [TestCase("987")]
        [TestCase("abcdef")]
        [TestCase("-j4985")]
        [TestCase("048204678448")]
        public void IsValidPin_InvalidInput_CorrectOutput(string pin)
        {
            // Arrange
            StandardAccountDetails details = new StandardAccountDetails("123", "Harry", pin, 1);
            DebitAccount test = new DebitAccount(details);

            // Act
            bool isValidPin = test.IsValidPin(pin);

            // Assert
            Assert.That(isValidPin == false);
        }
    }
}
