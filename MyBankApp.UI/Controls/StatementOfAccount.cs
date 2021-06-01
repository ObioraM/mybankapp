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
    public partial class StatementOfAccount : UserControl
    {
        public StatementOfAccount()
        {
            InitializeComponent();
            var transactions = Program.transactionRepo.GetTransactions(AccountRepository.CurrentAccountNum);
            foreach (Transaction t in transactions)
            {
                
                lvstatementofaccount.Items.Add(new ListViewItem(new string[]
                {

                    t.Id.ToString(),t.Amount.ToString(),t.TransType,t.Note,t.DateOfTransaction.ToString()
                 }));
                
            }
        }

        private void lvStatementOfAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
