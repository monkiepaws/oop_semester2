namespace AccountLibrary
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, string customerName, string pin)
            : base(accountNumber, customerName, pin)
        {
            
        }
        
        public override decimal BalanceInOneYear()
        {
            decimal futureBalance = this.Balance + (this.Balance * 0.02m);

            return futureBalance;
        }
    }
}