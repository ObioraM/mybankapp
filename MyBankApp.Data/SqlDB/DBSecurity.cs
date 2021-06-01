using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MyBankApp.Data
{
    public class DBSecurity : ISecurityData
    {
        private static string conString;
        private static SqlConnection myCon;

        
        public DBSecurity()
        {
            conString = "Data Source=.;Initial Catalog=MyBankAppDataBase;Integrated Security=True";
           

        }

        public bool AddSecurityToFile(Security secure)
        {
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "INSERT INTO securityDetails VALUES(@customerId, @userName, @password)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@customerId", secure.CustomerId);
                cmd.Parameters.AddWithValue("@userName", secure.UserName);
                cmd.Parameters.AddWithValue("@password", secure.Password);

                cmd.ExecuteNonQuery();

                connection.Close();

            }

            return true;
        }

        public bool GrantAccess(string username, string password, out int customerId)
        {
            customerId = 0;
            bool success = false;

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT * FROM securityDetails WHERE userName = @userName";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@userName", username);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    if (password == (string)sdr["password"])
                    {
                        customerId = (int)sdr["customerId"];
                        success = true;
                    }
                }
                connection.Close();
            }

            return success;
        }

        public int RowCount()
        {
            int count = 0;

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var sql = "SELECT COUNT(*) FROM securityDetails";
                SqlCommand cmd = new SqlCommand(sql, connection);

                count = (int)cmd.ExecuteScalar();
                connection.Close();
            }

            return count;
        }
    }
}
