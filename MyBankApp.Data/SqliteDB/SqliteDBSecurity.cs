using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBankApp.Data
{
    public class SqliteDBSecurity : ISecurityData
    {
        private DataContext _context = new DataContext();
        public bool AddSecurityToFile(Security secure)
        {
            _context.Add(secure);
            int affectedRows = _context.SaveChanges();
            if (affectedRows > 0)
            {
                return true;
            }
            return false;
        }

        public bool GrantAccess(string username, string password, out int customerId)
        {
            Security secure = _context.Securities.FirstOrDefault(security => security.Password == password && security.UserName == username);

            if (secure != null)
            {
                customerId = secure.CustomerId;
                return true;
            }
            customerId = -1;
            return false;

        }

        public int RowCount()
        {
            int numOfRecords = _context.Securities.ToList().Count;
            return numOfRecords;
        }
    }
}
