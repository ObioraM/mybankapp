using MyBankApp.BusinessLogic;
using MyBankApp.Models;
using MyBankApp.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBankApp.UI
{
    public partial class AccountPageForm : Form
    {
        public AccountPageForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositControlForm deposit = new DepositControlForm();
            ShowControl(deposit);
        }

        public void ShowControl(Control control)
        {
            mainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            mainContent.Controls.Add(control);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawalControl withdrawControl = new WithdrawalControl();
            ShowControl(withdrawControl);
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            TransferFundForm transferFund = new TransferFundForm();
            ShowControl(transferFund);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(Program.securityRepo, Program.customerRepo, Program.accountRepo, Program.transactionRepo);
            SecurityRepository.CurrentUserId = 0;
            mainForm.Show();
        }

        private void headerControl1_Load(object sender, EventArgs e)
        {

        }

        private void mainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            AccountBalance accountBalance = new AccountBalance();
            ShowControl(accountBalance);
        }

        private void btnAccountStatement_Click(object sender, EventArgs e)
        {
            StatementOfAccount accountStatement = new StatementOfAccount();
            ShowControl(accountStatement);

            
        }
    }
}
