using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.BusinessLogic.Interfaces
{
    public static class GlobalConfig
    {
        /// <summary>
        /// Setup of the global instance of the repository objects
        /// </summary>
        public static IAccountRepository IAccountRepoInstance { get; private set; }
        public static ICustomerRepository ICustomerRepoInstance { get; private set; }
        public static ISecurityRepository ISecurityRepoInstance { get; private set; }
        public static ITransactionRepository ITransactionRepoInstance { get; private set; }

        public static void AddIinstances()
        {
            AccountRepository accountRepo = new AccountRepository();
            IAccountRepoInstance = accountRepo;

            CustomerRepository customerRepo = new CustomerRepository();
            ICustomerRepoInstance = customerRepo;

            SecurityRepository securityRepo = new SecurityRepository();
            ISecurityRepoInstance = securityRepo;

            TransactionRepository transactionRepo = new TransactionRepository();
            ITransactionRepoInstance = transactionRepo;
        }

        public static void RemoveIinstance()
        {
            IAccountRepoInstance = null;
            ICustomerRepoInstance = null;
            ISecurityRepoInstance = null;
            ITransactionRepoInstance = null;
        }
    }
}
