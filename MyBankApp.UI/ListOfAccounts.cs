using MyBankApp.BusinessLogic;
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
    public partial class ListOfAccounts : Form
    {
        private readonly ICustomerRepository _customerRepo;
        public ListOfAccounts(ICustomerRepository customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListOfAccounts_Load(object sender, EventArgs e)
        {
            var user = _customerRepo.GetCustomer(SecurityRepository.CurrentUserId);
           
            lblFirstName.Text = user.FirstName;
            lblLastName.Text = user.LastName;
            
            //cbListOfAccount.DataSource = Program.accountRepo.GetAccount(SecurityRepository.CurrentUserId);
             foreach (var account in Program.accountRepo.GetAccount(SecurityRepository.CurrentUserId))
             {
                cbListOfAccount.Items.Add($"{account.AccountType} {account.AccountNumber}");
             }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm home = new MainForm(Program.securityRepo, Program.customerRepo, Program.accountRepo, Program.transactionRepo);
            SecurityRepository.CurrentUserId = 0;
            home.Show();

        }

        private void btnTestFirstAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountPageForm acctPage = new AccountPageForm();
            acctPage.Show();
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void cbListOfAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOpenNewAccount_Click(object sender, EventArgs e)
        {
            CreateAccountControl createAccount = new CreateAccountControl();
            ShowControl(createAccount);

        }

        public void ShowControl(Control control)
        {
            mainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            mainContent.Controls.Add(control);
        }

        private void btnSubmitAccountSelection_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbListOfAccount.Text))
                {
                    throw new Exception("Please select an account from the combo box above.");
                }
                else
                {
                    string accountNumberString = cbListOfAccount.Text.Split()[1];
                    AccountRepository.CurrentAccountNum = Convert.ToInt32(accountNumberString);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AccountPageForm acctPage = new AccountPageForm();
            this.Hide();
            acctPage.Show();

        }
    }
}
