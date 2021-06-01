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

namespace MyBankApp.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string email = tbEmail.Text;
            string intendedPassword = tbPassword.Text;
            string intendedUsername = tbUserName.Text;
            string initialDepositString = tbInitialDeposit.Text;
            string AcctType = String.Empty;



            try
            {

                Security securityDetails = Program.securityRepo.NewSecurityDetails(intendedUsername, intendedPassword, firstName, lastName, email);

                Account account;


                if (radBtnSavingsAccount.Checked)
                {
                    AcctType = "Savings";
                    account = Program.accountRepo.CreateAccount(AcctType);
                    account.CustomerID = securityDetails.CustomerId;
                }
                else if (radBtnCurrentAccount.Checked)
                {
                    AcctType = "Current";
                    account = Program.accountRepo.CreateAccount(AcctType);
                    account.CustomerID = securityDetails.CustomerId;
                }
                else
                {
                    throw new Exception("Please Select an Account type");
                }

                Program.accountRepo.Save(account);
                decimal initialDeposit;

                if (!decimal.TryParse(initialDepositString, out initialDeposit))
                {
                    throw new Exception("Please enter a valid deposit amount.");
                }

                Program.accountRepo.MakeDeposit(account.AccountNumber, initialDeposit, "Init. Deposit");
                
                SecurityRepository.CurrentUserId = securityDetails.CustomerId;
                this.Hide();

                ListOfAccounts listOfAccounts = new ListOfAccounts(Program.customerRepo);
                listOfAccounts.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
