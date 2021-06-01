using MyBankApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyBankApp.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Account")]
        public int AccountNumber { get; set; }
        public Account Account { get; set; }
        //public Account Account { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public string TransType { get; set; }
        public DateTime DateOfTransaction { get; set; }

        
        //Id = Utility.GenerateRandomNumber();

        // Default Constructor
        public Transaction()
        {
            Id = Utility.GenerateRandomNumber();
            DateOfTransaction = DateTime.Now;
        }

        // parameterized constructor and channing
        public Transaction(int accNum, decimal amt, string note, string transType) : this()
        {
            AccountNumber = accNum;
            Amount = amt;
            Note = note;
            TransType = transType;
        }

        public Transaction(int transactionId, int accNum, decimal amt, string transType, string note, DateTime date)
        {
            Id = transactionId;
            AccountNumber = accNum;
            Amount = amt;
            Note = note;
            TransType = transType;
            DateOfTransaction = date;
        }

    }
}
