using MyBankApp.BusinessLogic;
using MyBankApp.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBankApp.UI
{
    static class Program
    {
        public static IAccountRepository accountRepo ;
        public static ICustomerRepository customerRepo ;
        public static ISecurityRepository securityRepo ;
        public static ITransactionRepository transactionRepo;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfig.AddIinstances();

            accountRepo = GlobalConfig.IAccountRepoInstance;
            customerRepo = GlobalConfig.ICustomerRepoInstance;
            securityRepo = GlobalConfig.ISecurityRepoInstance;
            transactionRepo = GlobalConfig.ITransactionRepoInstance;


            Application.Run(new MainForm(securityRepo, customerRepo, accountRepo, transactionRepo));

            GlobalConfig.RemoveIinstance();
            //Application.Run(new SingleAccountPageForm());
        }
    }
}
