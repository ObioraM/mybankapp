using MyBankApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBankApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Account> AccountsList { get; set; }


        public Customer(int customerID)
        {
            CustomerID = customerID;
            AccountsList = new List<Account>();
        }


        public Customer(string firstName, string lastName, string email)
        {

            CustomerID = Utility.GenerateRandomNumber();
            AccountsList = new List<Account>();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public Customer(int custID, string firstName, string lastName, string email)
        {

            CustomerID = custID;
            AccountsList = new List<Account>();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }


    }
}
