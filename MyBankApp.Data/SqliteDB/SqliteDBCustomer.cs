using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBankApp.Data
{
    public class SqliteDBCustomer : ICustomerData
    {
        private static DataContext _context = new DataContext();
        public bool AddCustomerToFile(Customer cust)
        {
            _context.Add(cust);
            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public Customer GetCustomer(int customerId)
        {
            Customer cust = _context.Customers.FirstOrDefault(cust => cust.CustomerID == customerId);
            return cust;
        }

        public int RowCount()
        {
            return _context.Customers.ToList().Count;
        }
    }
}
