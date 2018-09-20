namespace AccountLibrary
{
    public class CreditAccount : Account
    {
        public decimal CreditLimit { get; set; }

        public CreditAccount(string accountNumber, string customerName, string pin, decimal creditLimit)
            : base(accountNumber, customerName, pin)
        {
            this.CreditLimit = creditLimit;
        }
        
        public override bool Withdrawal(decimal amount)
        {
            return base.Withdrawal(amount);
        }

        public override decimal BalanceInOneYear()
        {
            throw new System.NotImplementedException();
        }
    }
}