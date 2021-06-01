using MyBankApp.BusinessLogic;
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
    public partial class DepositControlForm : UserControl
    {
        public DepositControlForm()
        {
            InitializeComponent();
        }

        private void DepositControlForm_Load(object sender, EventArgs e)
        {

        }

        private void lblDeposit_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                if (string.IsNullOrWhiteSpace(tbAmountToDeposit.Text) && string.IsNullOrWhiteSpace(tbNote.Text))
                {
                    throw new Exception("Please enter a valid note and/or deposit amount.");
                }


                decimal deposit = decimal.Parse(tbAmountToDeposit.Text);
                string note = tbNote.Text;

                Program.accountRepo.MakeDeposit(AccountRepository.CurrentAccountNum, deposit, note);

                MessageBox.Show("Deposit Successful");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lnkLabelReturnToDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ListOfAccounts dashboard = new ListOfAccounts(Program.customerRepo);
            dashboard.Show();
        }
    }
}
