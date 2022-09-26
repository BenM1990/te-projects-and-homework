namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount() : base() { }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountNumber, accountNumber, balance) { }
        
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal overdraftFee = 10.00M;
            if(Balance < 0.00M && Balance > -100.00M)
            {
                return base.Withdraw(amountToWithdraw + overdraftFee);   
            }
            if(Balance - amountToWithdraw > 0)
            {
                return base.Withdraw(amountToWithdraw);
            }
            
            return Balance;
        }
    }
}
