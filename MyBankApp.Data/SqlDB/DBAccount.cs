using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MyBankApp.Data
{
    public class DBAccount : IAccountData
    {
        private static string conString;
        private static SqlConnection myCon;

        public DBAccount()
        {
            conString = "Data Source=.;Initial Catalog=MyBankAppDataBase;Integrated Security=True";
            
        }

        public bool AddAccountToFile(Account acct)
        {
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "INSERT INTO accounts VALUES(@accountNum, @customerId, @accountType, @minimumBalance)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@accountNum", acct.AccountNumber);
                cmd.Parameters.AddWithValue("@customerId", acct.CustomerID);
                cmd.Parameters.AddWithValue("@accountType", acct.AccountType);
                cmd.Parameters.AddWithValue("@minimumBalance", acct.MinimumAmount);

                cmd.ExecuteNonQuery();
              
                connection.Close();

            }
            return true;
        }

        public Account GetAccountByAccountNumber(int accountNumber)
        {
            Account account = null;
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT * FROM accounts WHERE accountNum = @accountNumber";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@accountNumber", accountNumber);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    int acctNum = (int)sdr["accountNum"];
                    int customerId = (int)sdr["customerId"];
                    string accountType = (string)sdr["accountType"];
                    decimal minimumAmount = (decimal)sdr["minimumBalance"];

                    account = new Account(accountNumber, customerId, accountType, minimumAmount ); //Customer(custId, firstName, lastName, email);
                }
                connection.Close();
            }
            return account;
        }

        public List<Account> GetAccountByCustomerId(int customerId)
        {
            List<Account> accountList = new List<Account>();
            Account account = null;
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT * FROM accounts WHERE customerId = @customerId";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@customerId", customerId);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    int acctNum = (int)sdr["accountNum"];
                    int customerID = (int)sdr["customerId"];
                    string accountType = (string)sdr["accountType"];
                    decimal minimumAmount = (decimal)sdr["minimumBalance"];

                    account = new Account(acctNum, customerID, accountType, minimumAmount);

                    accountList.Add(account);
                }
                connection.Close();
            }
            return accountList;
        }

        public bool NumberExist(int accountNumber)
        {
            bool exists = false;

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT * FROM accounts WHERE accountNum = @accountNumber";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@accountNumber", accountNumber);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    exists = true;
                }
                connection.Close();
            }
            return exists;
        }

        public int RowCount()
        {
            int count = 0;

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT COUNT(*) FROM accounts";
                SqlCommand cmd = new SqlCommand(sql, connection);

                count = (int)cmd.ExecuteScalar();
                connection.Close();
            }

            return count;
        }
    }
}
