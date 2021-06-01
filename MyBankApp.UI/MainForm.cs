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
    public partial class MainForm : Form
    {
        public readonly IAccountRepository accountRepo;
        public readonly ISecurityRepository securityRepo;
        public readonly ITransactionRepository transactionRepo;
        public readonly ICustomerRepository customerRepo;
        

        public MainForm(ISecurityRepository securityInstance, ICustomerRepository customerInstance, IAccountRepository accountInstance, ITransactionRepository transactionInstance)
        {
            InitializeComponent();
            accountRepo = accountInstance;
            customerRepo = customerInstance;
            securityRepo = securityInstance;
            transactionRepo = transactionInstance;
        }

        private void pnlMainArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lnklblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm newpage = new SignUpForm();
            newpage.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //try
            //{
                string username = txtBoxUserName.Text.Trim();
                string password = txtBoxPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    throw new Exception("Please enter valid username and password");
                }


                int customerId;

                if (securityRepo.GrantAccess(username, password, out customerId))
                {

                    SecurityRepository.CurrentUserId = customerId;

                } else
                {
                    throw new Exception("Please enter valid username and/or password");
                }

                this.Hide();
                ListOfAccounts listOfAccounts = new ListOfAccounts(customerRepo);
                listOfAccounts.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
