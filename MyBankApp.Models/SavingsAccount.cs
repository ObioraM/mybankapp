using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.Models
{
    public class SavingsAccount : Account
    {
        public override string AccountType { get => base.AccountType; }
        

        public SavingsAccount()
        {
            AccountType = "Savings";
            MinimumAmount = 1000;
        }

        
        
    }
}
