using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer : IAccountable
    {
       
        public List<IAccountable> Accountables { get; set; } = new List<IAccountable>();
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                decimal totalAccountableBalance = 0;
                foreach (IAccountable accountable in Accountables)
                {
                    totalAccountableBalance += accountable.Balance;
                }
                if (totalAccountableBalance >= 25000)
                {
                    return true;
                }

                else
                {
                    return false;
                }
                
                
            }
        }

        public decimal Balance { get; }

        public void AddAccount(IAccountable newAccount)
        {
            Accountables.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            return Accountables.ToArray();
        }
        
    

    }
}
