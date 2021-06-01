using MyBankApp.Models;
using System.Collections.Generic;

namespace MyBankApp.BusinessLogic
{
    public interface IAccountRepository
    {
        int RowCount { get; }

        bool AddAccount(Account anAccount);
        List<Account> GetAccount(int customerID);
        Account GetAccountByAcctNum(int accountNumber);
        Account CreateAccount(string acctType);
        decimal GetBalance(int accountNumber);
        void MakeDeposit(int accNum, decimal amt, string note, string type = "Deposit");
        void MakeTransfer(int senderNumber, int receiverNumber, decimal amt, string note, string type);
        bool NumberExists(int acctNumber);
        bool RemoveAccount(int AccountNumber);
        bool Save(Account anAccount);
        bool Withdrawal(int accNum, decimal amount, string note, string type = "Withdrawal");
    }
}