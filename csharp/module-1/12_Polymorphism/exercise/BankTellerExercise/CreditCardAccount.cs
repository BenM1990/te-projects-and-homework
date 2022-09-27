using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        public decimal Balance
        {
            get
            {
                return 0 - Debt;
            }
        }
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; } = 0;

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
           
        }

        public decimal Pay(decimal amountToPay)
        {
            return Debt -= amountToPay;
        }

        public decimal Charge(decimal amountToCharge)
        {
            return Debt += amountToCharge;
        }
    }
}
