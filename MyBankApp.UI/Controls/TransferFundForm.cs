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
    public partial class TransferFundForm : UserControl
    {
        public TransferFundForm()
        {
            InitializeComponent();
        }

        private void btnTransferSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                if (string.IsNullOrWhiteSpace(tbReceiverAccountNumber.Text) && string.IsNullOrWhiteSpace(tbAmountToTransfer.Text) && string.IsNullOrWhiteSpace(tbNote.Text))
                {
                    throw new Exception("Please enter a valid receiver accout number, note and/or transfer amount.");
                }
                
                decimal deposit;

                if (!decimal.TryParse(tbAmountToTransfer.Text, out deposit))
                {
                    throw new Exception("Transfer amount is invalid");
                }

                int accountNumber;

                if (!int.TryParse(tbReceiverAccountNumber.Text, out accountNumber))
                {
                    throw new Exception("Account number is invalid");
                }

                if (!Program.accountRepo.NumberExists(accountNumber))
                {
                    throw new Exception("Account number not in database");
                }


                Program.accountRepo.MakeTransfer(AccountRepository.CurrentAccountNum, accountNumber, deposit, tbNote.Text, "Transfer");

                MessageBox.Show("Transfer Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
