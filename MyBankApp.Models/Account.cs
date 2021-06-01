using MyBankApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBankApp.Models
{
    public class Account
    {
        private int _acctNum;
        [Key]
        public int AccountNumber { get 
            {
                return _acctNum;
            } set
            {
                _acctNum = value;
            }
        } 
        public int CustomerID { get; set; }
        public virtual string AccountType { get; set; }
        public List<Transaction> TransactionsList { get; set; }

        public virtual decimal MinimumAmount { get; set; }

        public Account()
        {
            _acctNum = Utility.GenerateRandomNumber();
            
            TransactionsList = new List<Transaction>();
        }
        public Account(int accountNum, int customerId, string accountType, decimal minimumAmount) : this()
        {
            AccountNumber = accountNum;
            CustomerID = customerId;
            AccountType = accountType;
            MinimumAmount = minimumAmount;
        }

    }
}
