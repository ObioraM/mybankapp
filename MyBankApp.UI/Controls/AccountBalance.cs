using MyBankApp.BusinessLogic;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBankApp.UI.Controls
{
    public partial class AccountBalance : UserControl
    {
        public AccountBalance()
        {
            InitializeComponent();
        }

        private void AccountBalance_Load(object sender, EventArgs e)
        {

            Account account = Program.accountRepo.GetAccountByAcctNum(AccountRepository.CurrentAccountNum);

            lblInsertAccountBalance.Text = Program.accountRepo.GetBalance(AccountRepository.CurrentAccountNum).ToString();//account.Balance.ToString();
            lblInsertAccountNumber.Text = account.AccountNumber.ToString();
            lblInsertAccountType.Text = account.AccountType;

        }
    }
}
