using MyBankApp.Data;
using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.BusinessLogic
{
    public class AccountRepository : IAccountRepository
    {
        public static int CurrentAccountNum;

        private readonly ITransactionRepository TransactionRepo;

        private readonly IAccountData accountDataAccess;


        private int _rowCount;
        public int RowCount
        {
            get
            {
                //_rowCount = DataStoreAccountTxt.RowCount();
                _rowCount = accountDataAccess.RowCount();
                return _rowCount;
            }

            private set
            {
                _rowCount = value;
            }
        }


        public AccountRepository()
        {
            TransactionRepo = new TransactionRepository();
            //accountDataAccess = new DBAccount();
            accountDataAccess = new SqliteDBAccount();
        }

        public List<Account> GetAccount(int customerID)
        {

            // Get a list of accounts for a customer.
            List<Account> accountList = accountDataAccess.GetAccountByCustomerId(customerID);

            // Populate the transactionList of each account of the customer.
            for (int i = 0; i < accountList.Count; i++)
            {
                accountList[i].TransactionsList = TransactionRepo.GetTransactions(accountList[i].AccountNumber);
            }
            // Return accountlist
            return accountList;
        }


        public bool Withdrawal(int accNum, decimal amount, string note, string type = "Withdrawal")
        {
            bool success = false;

            if (amount < 0)
            {
                throw new Exception("Invalid withdraw amount");
            }

            int transactionsCountBefore = TransactionRepo.CountRows();

            decimal balanceBefore = GetBalance(accNum);

            var account = accountDataAccess.GetAccountByAccountNumber(accNum);

            if (balanceBefore - amount < account.MinimumAmount)
            {
                throw new Exception("INVALID TRANSACTION ATTEMPT: Not allowed to have less than minimum balance.");
            }

            Transaction transaction = TransactionRepo.CreateTransaction(accNum, -amount, note, type);
            TransactionRepo.AddTransaction(transaction);

            int transactionCountAfter = TransactionRepo.CountRows();

            if (transactionsCountBefore < transactionCountAfter)
            {
                success = true;
            }


            return success;
        }

        // make transfer
        public void MakeTransfer(int senderNumber, int receiverNumber, decimal amt, string note, string type)
        {
            // ensure the amount is not less than zero
            if (amt < 0)
                throw new ArgumentOutOfRangeException(nameof(amt), "Transfer amount must be positive");

            // ensure number exists
            if (!NumberExists(receiverNumber))
                throw new InvalidOperationException("The receiver number is not recognised!");

            // ensure that the sender number and the receiver nuver is not the same
            if (senderNumber == receiverNumber)
                throw new InvalidOperationException("Transfer amount within same account is not allowed!");

            // withdraw from the sender and deposit to the receiver
            Withdrawal(senderNumber, amt, note, "Transfer debit");
            MakeDeposit(receiverNumber, amt, note, "Transfer credit");
        }


        // make deposit
        public void MakeDeposit(int accNum, decimal amt, string note, string type = "Deposit")
        {
            

            // ensure the amount is not less than zero
            if (amt <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amt), "Deposit amount must be positive");
            }

            // add a new deposit
            int countBeforeDeposit = TransactionRepo.CountRows();
            
            Transaction transaction = TransactionRepo.CreateTransaction(accNum, amt, note, type);
           
            TransactionRepo.AddTransaction(transaction);

            int countAfterDeposit = TransactionRepo.CountRows();

            if (countAfterDeposit <= countBeforeDeposit)
            {
                throw new Exception("Failed to add transaction!");
            }

        }

        public Account CreateAccount(string acctType)
        {
            Account account = null;
            if (acctType == "Savings") {
                account = new SavingsAccount();
                //Save(account);
                return account;
            }
            if (acctType == "Current")
            {
                account = new CurrentAccount();
                //Save(account);
                return account;
            }

            return account;
        }



        // get balance
        public decimal GetBalance(int accountNumber)
        {

            decimal balance = 0;
           
            List<Transaction> transactions = TransactionRepo.GetTransactions(accountNumber);

            foreach (Transaction transaction in transactions)
            {
                balance += transaction.Amount;
            }
            
            return balance;
        }

        public bool Save(Account anAccount)
        {

            accountDataAccess.AddAccountToFile(anAccount);

            foreach (Transaction transaction in anAccount.TransactionsList)
            {
                if (!TransactionRepo.TransactionExists(transaction.Id))
                {
                    TransactionRepo.AddTransaction(transaction);
                }
            }

            return true;
        }



        public bool RemoveAccount(int accountNumber)
        {
            // not yet implemented
            return false;
        }

        public bool NumberExists(int acctNumber)
        {
            
            return accountDataAccess.NumberExist(acctNumber);
        }

        // get accout by account number
        public Account GetAccountByAcctNum(int accnum)
        {
            
            Account account = accountDataAccess.GetAccountByAccountNumber(accnum);
            account.TransactionsList = TransactionRepo.GetTransactions(accnum);

            return account;


        }



        // add new account
        public bool AddAccount(Account anAccount)
        {

            Save(anAccount);

            return true;
        }
    }
}
