using MyBankApp.BusinessLogic;
using MyBankApp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Tests
{
    public class CustomerRepositoryShould
    {
        CustomerRepository customerRepo = new CustomerRepository();

        [Test]
        public void GetCustomerWithIdWorks()
        {
            int id = 486426663;


            Customer cust = customerRepo.GetCustomer(id);


            Assert.That(cust.FirstName, Is.EqualTo("Obiora"));
            Assert.That(cust.LastName, Is.EqualTo("Maduakor"));
            Assert.That(cust.Email, Is.EqualTo("obioramaduakor@gmail.com"));
        }
        [Test]
        public void SaveWorks()
        {
            int newCustId = Common.Utility.GenerateRandomNumber();

            Customer cust = new Customer(newCustId)
            {
                FirstName = "Olumide",
                LastName = "Joda",
                Email = "olumidejoda@gmail.com"
            };
            bool success = customerRepo.Save(cust);

            Customer newCust = customerRepo.GetCustomer(newCustId);

            Assert.That(success, Is.EqualTo(true));
            Assert.That(newCust.CustomerID, Is.EqualTo(cust.CustomerID));
            Assert.That(newCust.FirstName, Is.EqualTo(cust.FirstName));
            Assert.That(newCust.LastName, Is.EqualTo(cust.LastName));
            Assert.That(newCust.Email, Is.EqualTo(cust.Email));
            
        }

        
    }
}
