using MyBankApp.Models;
using System.Collections.Generic;

namespace MyBankApp.BusinessLogic
{
    public interface ITransactionRepository
    {
        int RowCount { get; }

        bool AddTransaction(Transaction aTransaction);
        int CountRows();
        Transaction CreateTransaction(int acctNum, decimal amt, string note, string transType);
        List<Transaction> GetTransactions(int accountNumber);
        bool TransactionExists(int id);
    }
}