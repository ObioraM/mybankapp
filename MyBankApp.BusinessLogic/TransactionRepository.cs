using MyBankApp.Data;
using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.BusinessLogic
{
    public class TransactionRepository : ITransactionRepository
    {
        public int RowCount { get; private set; }
        private readonly ITransactionData transactionDataAccess;



        public TransactionRepository()
        {
            
            transactionDataAccess = new SqliteDBTransaction();
            RowCount = transactionDataAccess.RowCount();
        }

        public Transaction CreateTransaction(int acctNum, decimal amt, string note, string transType)
        {

            Transaction transaction = new Transaction(acctNum, amt, note, transType);

            return transaction;
        }
        public List<Transaction> GetTransactions(int accountNumber)
        {

            
            List<Transaction> TransactionsList = transactionDataAccess.GetTransactionByAccountNumber(accountNumber);

            return TransactionsList;
        }

        // add transaction
        public bool AddTransaction(Transaction aTransaction)
        {

            bool isAdded = false;

            
            RowCount = transactionDataAccess.RowCount();

            transactionDataAccess.AddTransactionToFile(aTransaction);


            if (RowCount < transactionDataAccess.RowCount())
            {
                isAdded = true;
                
                RowCount = transactionDataAccess.RowCount();
            }

            return isAdded;
        }

        
        public int CountRows()
        {
            
            return transactionDataAccess.RowCount();
        }

        public bool TransactionExists(int transactionId)
        {
            
            return transactionDataAccess.TransactionExists(transactionId);
        }
    }
}
