using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MyBankApp.Data
{
    public class DBCustomer : ICustomerData
    {
        public string conString = "Data Source=.;Initial Catalog=MyBankAppDataBase;Integrated Security=True";
        


        public bool AddCustomerToFile(Customer cust)
        {
           
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "INSERT INTO customers VALUES(@customerId, @firstName, @lastName, @email)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@customerId", cust.CustomerID);
                cmd.Parameters.AddWithValue("@firstName", cust.FirstName);
                cmd.Parameters.AddWithValue("@lastName", cust.LastName);
                cmd.Parameters.AddWithValue("@email", cust.Email);

                cmd.ExecuteNonQuery();

                connection.Close();

            }

            return true;
        }

        public Customer GetCustomer(int customerId)
        {
            Customer cust = null;
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT * FROM customers WHERE customerId = @Id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Id", customerId);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    int custId = (int)sdr["customerId"];
                    string firstName = (string)sdr["firstName"];
                    string lastName = (string)sdr["lastName"];
                    string email = (string)sdr["email"];

                    cust = new Customer(custId, firstName, lastName, email);
                }
                connection.Close();
            }
            return cust;
        }

        public int RowCount()
        {
            int count = 0;

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT COUNT(*) FROM customers";
                SqlCommand cmd = new SqlCommand(sql, connection);

                count = (int)cmd.ExecuteScalar();
                connection.Close();
            }

            return count;
        }
    }
}
