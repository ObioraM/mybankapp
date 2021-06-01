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
    public partial class CreateAccountControl : UserControl
    {
        public CreateAccountControl()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccountControl_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitNewAccountDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            string initialDepositString = tbInitialDeposit.Text;
            string AcctType = String.Empty;


            try
            {

                Account account;


                if (radBtnSavings.Checked)
                {
                    AcctType = "Savings";
                    account = Program.accountRepo.CreateAccount(AcctType);
                    account.CustomerID = SecurityRepository.CurrentUserId;
                }
                else if (radBtnCurrentAccount.Checked)
                {
                    AcctType = "Current";
                    account = Program.accountRepo.CreateAccount(AcctType);
                    account.CustomerID = SecurityRepository.CurrentUserId;
                }
                else
                {
                    throw new Exception("Please Select an Account type");
                }

                decimal initialDeposit;

                if (!decimal.TryParse(initialDepositString, out initialDeposit))
                {
                    throw new Exception("Please enter a valid deposit amount.");
                }

                Program.accountRepo.Save(account);
                Program.accountRepo.MakeDeposit(account.AccountNumber, initialDeposit, "Init. Deposit");


                this.Hide();

                ListOfAccounts listOfAccounts = new ListOfAccounts(Program.customerRepo);
                listOfAccounts.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Account creation successful");
            this.Hide();

            ListOfAccounts dashboard = new ListOfAccounts(Program.customerRepo);

            dashboard.Show();

        }
    
    }
}
