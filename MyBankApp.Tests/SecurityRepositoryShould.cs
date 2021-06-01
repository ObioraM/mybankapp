using MyBankApp.BusinessLogic;
using MyBankApp.Common;
using MyBankApp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Tests
{
    [TestFixture]
    public class SecurityRepositoryShould
    {
        SecurityRepository securityRepo = new SecurityRepository();

        [Test]
        public void GrantAccessToUserValid()
        {
            int holdCustId;
            var sut = securityRepo.GrantAccess("obioram", "123", out holdCustId);

            Assert.That(sut, Is.EqualTo(true));
        }

        [Test]
        public void GrantAccessToUserInvalid()
        {
            int holdCustId;
            // using wrong username
            var sut = securityRepo.GrantAccess("obiora", "123", out holdCustId);

            Assert.That(sut, Is.EqualTo(false));
        }

        [Test]
        public void NewSecurityDetailsWorksValid()
        {
            // Arrange
            int Id;
            string username = "username " + DateTime.Now.ToString();
            Security secure = securityRepo.NewSecurityDetails(username, "234", "Obi", "Maduakor", "obioramad@gm.com");

            // Act
            var sut = securityRepo.GrantAccess(username, "234", out Id);

            // Assert
            Assert.That(sut, Is.EqualTo(true));

        }

        [Test]
        public void NewSecurityDetailsWorksCustomerAlreadyPresent()
        {
            // Arrange
            
            Assert.Throws<Exception>(()=>securityRepo.NewSecurityDetails("obi1", "234", "Obi", "Maduakor", "obioramad@gm.com"));
                               
            


        }
    }
}
