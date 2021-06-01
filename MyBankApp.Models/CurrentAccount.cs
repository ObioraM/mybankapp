using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.Models
{
    public class CurrentAccount : Account
    {
        public override string AccountType { get => base.AccountType; }

        public CurrentAccount()
        {
            AccountType = "Current";
            MinimumAmount = 0;
        }

    }
}
