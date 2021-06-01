
namespace MyBankApp.UI
{
    partial class AccountPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBankLogo = new System.Windows.Forms.Label();
            this.pnlBankLogo = new System.Windows.Forms.Panel();
            this.headerControl1 = new MyBankApp.UI.Controls.HeaderControl();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAccountStatement = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTransferMoney = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.mainContent = new System.Windows.Forms.Panel();
            this.lvStatementOfAccount = new System.Windows.Forms.ListView();
            this.columnTransactionId = new System.Windows.Forms.ColumnHeader();
            this.columnTransactionType = new System.Windows.Forms.ColumnHeader();
            this.columnAmount = new System.Windows.Forms.ColumnHeader();
            this.columnNote = new System.Windows.Forms.ColumnHeader();
            this.columnDate = new System.Windows.Forms.ColumnHeader();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlBankLogo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.mainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBankLogo
            // 
            this.lblBankLogo.AutoSize = true;
            this.lblBankLogo.Location = new System.Drawing.Point(-38, -69);
            this.lblBankLogo.Name = "lblBankLogo";
            this.lblBankLogo.Size = new System.Drawing.Size(59, 25);
            this.lblBankLogo.TabIndex = 0;
            this.lblBankLogo.Text = "label1";
            // 
            // pnlBankLogo
            // 
            this.pnlBankLogo.Controls.Add(this.headerControl1);
            this.pnlBankLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlBankLogo.Name = "pnlBankLogo";
            this.pnlBankLogo.Size = new System.Drawing.Size(1016, 112);
            this.pnlBankLogo.TabIndex = 1;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.ForeColor = System.Drawing.Color.White;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(1016, 112);
            this.headerControl1.TabIndex = 0;
            this.headerControl1.Load += new System.EventHandler(this.headerControl1_Load);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnAccountStatement);
            this.pnlMenu.Controls.Add(this.btnCheckBalance);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnTransferMoney);
            this.pnlMenu.Controls.Add(this.btnWithdraw);
            this.pnlMenu.Controls.Add(this.btnDeposit);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 112);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 431);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnAccountStatement
            // 
            this.btnAccountStatement.Location = new System.Drawing.Point(29, 230);
            this.btnAccountStatement.Name = "btnAccountStatement";
            this.btnAccountStatement.Size = new System.Drawing.Size(192, 34);
            this.btnAccountStatement.TabIndex = 6;
            this.btnAccountStatement.Text = "Account Statement";
            this.btnAccountStatement.UseVisualStyleBackColor = true;
            this.btnAccountStatement.Click += new System.EventHandler(this.btnAccountStatement_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(29, 176);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(192, 34);
            this.btnCheckBalance.TabIndex = 5;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Location = new System.Drawing.Point(29, 347);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 34);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTransferMoney
            // 
            this.btnTransferMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransferMoney.Location = new System.Drawing.Point(29, 123);
            this.btnTransferMoney.Name = "btnTransferMoney";
            this.btnTransferMoney.Size = new System.Drawing.Size(192, 34);
            this.btnTransferMoney.TabIndex = 3;
            this.btnTransferMoney.Text = "Transfer Money";
            this.btnTransferMoney.UseVisualStyleBackColor = true;
            this.btnTransferMoney.Click += new System.EventHandler(this.btnTransferMoney_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWithdraw.Location = new System.Drawing.Point(29, 74);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(192, 34);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeposit.Location = new System.Drawing.Point(29, 24);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(192, 34);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // mainContent
            // 
            this.mainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.mainContent.Controls.Add(this.lvStatementOfAccount);
            this.mainContent.Controls.Add(this.lblFirstName);
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainContent.Location = new System.Drawing.Point(250, 112);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(766, 431);
            this.mainContent.TabIndex = 3;
            this.mainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContent_Paint);
            // 
            // lvStatementOfAccount
            // 
            this.lvStatementOfAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTransactionId,
            this.columnTransactionType,
            this.columnAmount,
            this.columnNote,
            this.columnDate});
            this.lvStatementOfAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStatementOfAccount.HideSelection = false;
            this.lvStatementOfAccount.Location = new System.Drawing.Point(0, 0);
            this.lvStatementOfAccount.Name = "lvStatementOfAccount";
            this.lvStatementOfAccount.Size = new System.Drawing.Size(766, 431);
            this.lvStatementOfAccount.TabIndex = 2;
            this.lvStatementOfAccount.UseCompatibleStateImageBehavior = false;
            // 
            // columnTransactionId
            // 
            this.columnTransactionId.Text = "Transaction ID";
            // 
            // columnTransactionType
            // 
            this.columnTransactionType.Text = "TransactionType";
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            // 
            // columnNote
            // 
            this.columnNote.Text = "Note";
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(-256, -98);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 25);
            this.lblFirstName.TabIndex = 1;
            // 
            // AccountPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 543);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBankLogo);
            this.Controls.Add(this.lblBankLogo);
            this.Name = "AccountPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.pnlBankLogo.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.mainContent.ResumeLayout(false);
            this.mainContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankLogo;
        private System.Windows.Forms.Panel pnlBankLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTransferMoney;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Panel pnlAccounts;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.ListView lvStatementOfAccount;
        private System.Windows.Forms.ColumnHeader columnTransactionId;
        private System.Windows.Forms.ColumnHeader columnTransactionType;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnNote;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Button btnAccountStatement;
    }
}