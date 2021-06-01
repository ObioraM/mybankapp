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
    public class AccountRepositoryShould
    {

        
        AccountRepository accRepo = new AccountRepository();

        [Test]
        public void GetAccountWithCustomerIdWorks()
        {
            List<Account> acctList = accRepo.GetAccount(486426663);

            Assert.That(acctList.Any(acct => acct.AccountNumber == 188336728));
            Assert.That(acctList.Any(acct => acct.AccountNumber == 419172678));

        }

        [Test]
        public void GetBalance()
        {
            int acctNum = 905950559;

            decimal expectedBalance = 0m;

            Assert.That(accRepo.GetBalance(acctNum), Is.EqualTo(expectedBalance));

        }

        [Test]
        public void GetAccountWithAccountNumberWorks()
        {
            int acctNum = 188336728;

            Account account = accRepo.GetAccountByAcctNum(acctNum);

            Assert.That(account.CustomerID, Is.EqualTo(486426663));
            Assert.That(account.AccountType, Is.EqualTo("Savings"));
            Assert.That(account.MinimumAmount, Is.EqualTo(1000m));
        }

        [Test]
        public void CreateAccountWorks()
        {
            Account acct1 = accRepo.CreateAccount("Savings");
            Account acct2 = accRepo.CreateAccount("Current");

            Assert.That(acct1.AccountType, Is.EqualTo("Savings"));
            Assert.That(acct2.AccountType, Is.EqualTo("Current"));

        }



        [Test]
        public void SaveAccountWorks()
        {

            // Arrange
            int custId = 486426663;
            Account acct = new SavingsAccount();

            int acctNum = acct.AccountNumber;
            acct.CustomerID = custId;

            // Act
            bool success = accRepo.Save(acct);
            Account retrieveAcct = accRepo.GetAccountByAcctNum(acctNum);

            // Assert
            Assert.That(success, Is.EqualTo(true));
            Assert.That(retrieveAcct.AccountType, Is.EqualTo(acct.AccountType));
            Assert.That(retrieveAcct.MinimumAmount, Is.EqualTo(acct.MinimumAmount));
            Assert.That(retrieveAcct.CustomerID, Is.EqualTo(acct.CustomerID));


        }

        [Test]
        public void DepositValidAmount()
        {
            // Arrange
            int acctNum = 188336728;
            decimal depositAmt = 10000m;
            decimal balanceBefore = accRepo.GetBalance(acctNum);
            decimal expectedBalanceAfter = balanceBefore + depositAmt;

            // Act
            accRepo.MakeDeposit(acctNum, depositAmt, "Test Deposit function");

            // Assert
            Assert.That(accRepo.GetBalance(acctNum), Is.EqualTo(expectedBalanceAfter));
        }

        [Test]
        public void NotDepositInvalidAmount()
        {
            // Arrange
            int acctNum = 188336728;
            decimal depositAmt = -100m;

            Assert.Throws<ArgumentOutOfRangeException>(() => accRepo.MakeDeposit(acctNum, depositAmt, "Test Amount function"));


        }

        [Test]
        public void WithdrawValidAmount()
        {
            // Arrange
            int acctNum = 188336728;
            decimal withdrawAmt = 100m;
            decimal balanceBefore = accRepo.GetBalance(acctNum);
            decimal expectedBalanceAfter = balanceBefore - withdrawAmt;

            accRepo.Withdrawal(acctNum, withdrawAmt, "Test Amount function");

            Assert.That(accRepo.GetBalance(acctNum), Is.EqualTo(expectedBalanceAfter));

        }

        [Test]
        public void NotWithdrawInvalidAmount()
        {
            // Arrange
            int acctNum = 188336728;
            decimal withdrawAmt = -100m;

            Assert.Throws<Exception>(()=> accRepo.Withdrawal(acctNum, withdrawAmt, "Test Amount function"));


        }

        [Test]
        public void Transfer()
        {
            int acctSenderNum = 188336728;
            int acctReceiverNum = 419172678;

            decimal senderBalanceBefore = accRepo.GetBalance(acctSenderNum);
            decimal receiverBalanceBefore = accRepo.GetBalance(acctReceiverNum);
            decimal transferAmount = 1000m;

            decimal expectedSenderBalance = senderBalanceBefore - transferAmount;
            decimal expectedReceiverBalance = receiverBalanceBefore + transferAmount;


            accRepo.MakeTransfer(acctSenderNum, acctReceiverNum, transferAmount, "Test transfer", "Transfer");

            Assert.That(accRepo.GetBalance(acctSenderNum), Is.EqualTo(expectedSenderBalance));
            Assert.That(accRepo.GetBalance(acctReceiverNum), Is.EqualTo(expectedReceiverBalance));

        }

        [Test]
        public void NotTransferValid()
        {
            int acctSenderNum = 188336728;
            int acctReceiverNum = 419172678;

            decimal transferAmount = -1000m;


            Assert.Throws<ArgumentOutOfRangeException>(()=>accRepo.MakeTransfer(acctSenderNum, acctReceiverNum, transferAmount, "Test Invalid transfer", "Invalid Transfer"));


        }
    }
}
