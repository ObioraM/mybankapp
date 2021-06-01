using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.Data.DSInterfaces
{
    public interface ITransactionData
    {
        //static string TransactionFileTxt = @"C:\Users\hp\Documents\Decagon_Projects\week5-ObioraM\MyBankApp\Transaction.txt";

        int RowCount();

        bool TransactionExists(int transactionId);

        // Transaction
        bool AddTransactionToFile(Transaction transaction);


        List<Transaction> GetTransactionByAccountNumber(int accountNumber);
    }
}
