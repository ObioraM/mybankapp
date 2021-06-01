using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBankApp.Data
{
    public class SqliteDBAccount : IAccountData
    {
        private static DataContext _context = new DataContext();
        public bool AddAccountToFile(Account acct)
        {
            _context.Add(acct);
            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0) return true;
            return false;
        }

        public Account GetAccountByAccountNumber(int accountNumber)
        {
            Account acct = _context.Accounts.FirstOrDefault(acct => acct.AccountNumber == accountNumber);
            return acct;
        }

        public List<Account> GetAccountByCustomerId(int customerId)
        {
            List<Account> listOfAccounts = _context.Accounts.Where(acct => acct.CustomerID == customerId).ToList();
            return listOfAccounts;
        }

        public bool NumberExist(int accountNumber)
        {
            return _context.Accounts.Any(acct => acct.AccountNumber == accountNumber);
        }

        public int RowCount()
        {
            return _context.Accounts.ToList().Count;
        }
    }
}
