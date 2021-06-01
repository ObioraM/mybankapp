using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyBankApp.Models
{
    public class Security
    {

        //public int Id { get; set; }
        [Key]
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Security()
        {

        }

        public Security(string username, string password)
        {
            UserName = username;
            Password = password;

        }
        
    }
}
