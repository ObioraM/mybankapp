using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBankApp.Data
{
    public class SqliteDBTransaction : ITransactionData
    {
        private static DataContext _context = new DataContext();
        public bool AddTransactionToFile(Transaction transaction)
        {
            _context.Add(transaction);
            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public List<Transaction> GetTransactionByAccountNumber(int accountNumber)
        {
            List<Transaction> listOfTransactions = _context.Transactions.Where(trans => trans.AccountNumber == accountNumber)
                                                                        .ToList();

            return listOfTransactions;
        }

        public int RowCount()
        {
            return _context.Transactions.ToList().Count;
        }

        public bool TransactionExists(int transactionId)
        {
            return _context.Transactions.Any(trans => trans.Id == transactionId);
        }
    }
}
