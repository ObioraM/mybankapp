using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.Data.DSInterfaces
{
    public interface ICustomerData
    {
        //static string CustomerFileTxt = @"C:\Users\hp\Documents\Decagon_Projects\week5-ObioraM\MyBankApp\Customer.txt";

        int RowCount();

        // Customer
        bool AddCustomerToFile(Customer cust);


        Customer GetCustomer(int customerId);

    }
}
