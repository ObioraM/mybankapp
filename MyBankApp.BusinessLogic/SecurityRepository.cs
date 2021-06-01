using MyBankApp.Data;
using MyBankApp.Data.DSInterfaces;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.BusinessLogic
{
    // Handles operations on security objects and log in and log out
    public class SecurityRepository : ISecurityRepository
    {
        public static int CurrentUserId;

        CustomerRepository customerRepo;
        private ISecurityData securityDataAccess;

        public SecurityRepository()
        {
            customerRepo = new CustomerRepository();
            
            securityDataAccess = new SqliteDBSecurity();
        }



        public bool GrantAccess(string username, string password, out int customerId)
        {
            
            bool accessGranted = securityDataAccess.GrantAccess(username, password, out customerId);
            return accessGranted;
        }


        public Security NewSecurityDetails(string username, string password, string firstName, string lastName, string email)
        {

            int customerId;
            // First check if Security detail exists
            if (securityDataAccess.GrantAccess(username,password, out customerId))
            {
                throw new Exception("Invalid username and/or password. Please try again.");
            }


            Security securityDetails = new Security(username, password);

            Customer aCustomer = customerRepo.NewCustomer(firstName, lastName, email);

           
            securityDetails.CustomerId = aCustomer.CustomerID;

            Save(securityDetails);

            return securityDetails;

        }

        public bool Save(Security customerSecurityDetail)
        {
            // Logic for saving security details

            return securityDataAccess.AddSecurityToFile(customerSecurityDetail);

        }

    }

}
