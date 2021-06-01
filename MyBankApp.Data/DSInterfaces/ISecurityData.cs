using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.Data.DSInterfaces
{
    public interface ISecurityData
    {
        //static string SecurityFileTxt = @"C:\Users\hp\Documents\Decagon_Projects\week5-ObioraM\MyBankApp\Security.txt";

        int RowCount();

        // Security
        bool AddSecurityToFile(Security secure);

        bool GrantAccess(string username, string password, out int customerId);
    }
}
