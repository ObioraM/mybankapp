using MyBankApp.BusinessLogic;
using MyBankApp.Common;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp
{
    public static class FrmRegister
    {
        private static readonly SecurityRepository securityRepository;
        private static readonly AccountRepository accountRepository;
        private static readonly TransactionRepository transactionRepository;

        static FrmRegister()
        {
            securityRepository = new SecurityRepository();
            accountRepository = new AccountRepository();

        }

        public static bool Register()
        {
            Console.WriteLine();
            Console.WriteLine("*******Note: All fields are required*******\n");
            Console.WriteLine("\nEnter last name");
            var lastName = Console.ReadLine();
            Console.WriteLine("\nEnter first name");
            var firstName = Console.ReadLine();
            Console.WriteLine("\nEnter email - eg: abc@efg.com");
            var email = Console.ReadLine();
            // is email valid?
            while (!Utility.IsEmailValid(email))
            {
                Console.WriteLine("\nInvalid email format.\n");

                Console.WriteLine("Enter your Email again Or enter 'E' to escape this propmt");
                email = Console.ReadLine();
                if (email.Equals("E"))
                    break;
            }
            Console.WriteLine("\nEnter your intended username: ");
            var userName = Console.ReadLine();

            Console.WriteLine("\nEnter password");
            var password = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Select Account type:  \n0: Savings,\t 1: Current");
            var accType = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter your initial balance");
            var bal = decimal.Parse(Console.ReadLine());


            // construct the user object and Security details
            Security secureHandle = securityRepository.NewSecurityDetails(userName, password, firstName, lastName, email);



            // construct the account object
            string[] accNames = { "Savings", "Current" };
            Account[] accObjs = {
                new SavingsAccount(),
                new CurrentAccount()
            };
            Account account = null;
            for (int i = 0; i < accObjs.Length; i++)
            {
                if (accObjs[i].AccountType.Equals(accNames[accType]))
                {
                    accObjs[i].CustomerID = secureHandle.CustomerId;
                    accObjs[i].Balance = accountRepository.GetBalance(accObjs[i].AccountNumber);
                    account = accObjs[i];
                    break;
                }
            }

            // add transaction to account
            Transaction transaction = new Transaction(account.AccountNumber, bal, "Initial deposit", account.AccountType, "Deposit");
            transactionRepository.AddTransaction(transaction);



            accountRepository.GetAccount(secureHandle.CustomerId);


            account.TransactionsList.Add(new Transaction(account.AccountNumber, bal, "Initial deposit",account.AccountType, "Deposit"));//account.AccountNumber, bal, "Initial deposit", account.AccType));

            int anIndex;
            return securityRepository.GrantAccess(userName, password, out anIndex);


            // add account to user
            //user.AccountsList.Add(account);

            // Register using repository
            //return securityRepository.Register(user, password);
        }
    }
}
