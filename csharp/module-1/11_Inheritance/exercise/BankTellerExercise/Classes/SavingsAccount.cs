namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount() : base() { }
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountNumber, accountNumber, balance) { }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal serviceCharge = 2.00M;
            if (Balance - amountToWithdraw <= 0)
                return Balance;
            if(amountToWithdraw > Balance)
            {
                return Balance;
            }
            if (Balance - amountToWithdraw < 150.00M)
            {
                return base.Withdraw(amountToWithdraw + serviceCharge);
            }
            else if (Balance >= 150.00M)
            {
                return base.Withdraw(amountToWithdraw);
            }
            

            return Balance;

        }
    }
        
    
}