using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.Data.DSInterfaces
{
    public interface IAccountData
    {
        //static string AccountFileTxt = @"C:\Users\hp\Documents\Decagon_Projects\week5-ObioraM\MyBankApp\Account.txt";


        // Account
        bool AddAccountToFile(Account acct);



        Account GetAccountByAccountNumber(int accountNumber);

        int RowCount();


        bool NumberExist(int accountNumber);

        List<Account> GetAccountByCustomerId(int customerId);

    }
}
