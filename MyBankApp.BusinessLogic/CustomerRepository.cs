using MyBankApp.Data;
using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;

namespace MyBankApp.BusinessLogic
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AccountRepository accountRepo;
        private readonly ICustomerData customerDataAccess;

        public CustomerRepository()
        {
            accountRepo = new AccountRepository();
            //customerDataAccess = new DBCustomer();
            customerDataAccess = new SqliteDBCustomer();
        }


        public bool Save(Customer aCustomer)
        {
            //int rowCountBefore = DataStoreCustomerTxt.RowCount();
            int rowCountBefore = customerDataAccess.RowCount();
            bool isSaved = false;

            customerDataAccess.AddCustomerToFile(aCustomer);

            int rowCountAfter = customerDataAccess.RowCount();

            if (rowCountBefore < rowCountAfter)
            {
                isSaved = true;
            }
            return isSaved;
        }

        public Customer NewCustomer(string firstName, string lastName, string Email)
        {
            Customer aCustomer = new Customer(firstName, lastName, Email);

            Save(aCustomer);

            return aCustomer;
        }

        public Customer GetCustomer(int customerId)
        {
            Customer acustomer = customerDataAccess.GetCustomer(customerId);

            acustomer.AccountsList = accountRepo.GetAccount(customerId);

            return acustomer;
        }

    }
}
