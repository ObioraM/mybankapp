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
    public partial class WithdrawalControl : UserControl
    {
        public WithdrawalControl()
        {
            InitializeComponent();
        }

        private void depositControlForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitWithdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                if (string.IsNullOrWhiteSpace(tbAmountToWithdraw.Text) && string.IsNullOrWhiteSpace(tbNote.Text))
                {
                    throw new Exception("Please enter a valid note and/or withdraw amount.");
                }


                decimal deposit = decimal.Parse(tbAmountToWithdraw.Text);
                string note = tbNote.Text;

                Program.accountRepo.Withdrawal(AccountRepository.CurrentAccountNum, deposit, note);

                MessageBox.Show("Withdrawal Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
