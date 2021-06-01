using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MyBankApp.Data
{
    public class DBTransaction : ITransactionData
    {
        private static string conString;

        public DBTransaction()
        {
            conString = "Data Source=.;Initial Catalog=MyBankAppDataBase;Integrated Security=True";
           

        }

        public bool AddTransactionToFile(Transaction transaction)
        {


            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "INSERT INTO transactionsTable VALUES(@transactionId, @amount, @note, @transactionType, @DateOfTransaction, @accountNumber)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@accountNumber", transaction.AccountNumber);
                cmd.Parameters.AddWithValue("@transactionId", transaction.Id);
                cmd.Parameters.AddWithValue("@amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@note", transaction.Note);
                cmd.Parameters.AddWithValue("@DateOfTransaction", transaction.DateOfTransaction);
                cmd.Parameters.AddWithValue("@transactionType", transaction.TransType);
            

                cmd.ExecuteNonQuery();

                connection.Close();
            }

            return true;

        }

        public List<Transaction> GetTransactionByAccountNumber(int accountNumber)
        {
            List<Transaction> transactionList = new List<Transaction>();
            Transaction transaction = null;

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT * FROM transactionsTable WHERE accountNumber = @AccountNumber";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    int accountNum = (int)sdr["accountNumber"];
                    int id = (int)sdr["transactionId"];
                    Decimal amount = (decimal)sdr["amount"];
                    string typeTrans = (string)sdr["transactionType"];
                    string note = (string)sdr["note"];
                    DateTime date = (DateTime)sdr["DateOfTransaction"];

                    transaction = new Transaction(id, accountNum, amount, typeTrans, note, date);
                    transactionList.Add(transaction);

                }

                connection.Close();
            }
            return transactionList;
        }

        public int RowCount()
        {
            int count = 0;

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT COUNT(*) FROM transactionsTable";
                SqlCommand cmd = new SqlCommand(sql, connection);

                count = (int)cmd.ExecuteScalar();
                connection.Close();
            }

            return count;
        }

        public bool TransactionExists(int transactionId)
        {
            bool exists = false;

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT * FROM transactionsTable WHERE transactionId = @transactionId";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@transactionId", transactionId);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    exists = true;
                }
                connection.Close();
            }
            return exists;
        }

    }
}
