
namespace MyBankApp.UI
{
    partial class ListOfAccounts
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
            this.pnlBankLogo = new System.Windows.Forms.Panel();
            this.headerControl1 = new MyBankApp.UI.Controls.HeaderControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOpenNewAccount = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.mainContent = new System.Windows.Forms.Panel();
            this.btnSubmitAccountSelection = new System.Windows.Forms.Button();
            this.lblSelectAccount = new System.Windows.Forms.Label();
            this.cbListOfAccount = new System.Windows.Forms.ComboBox();
            this.pnlBankLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBankLogo
            // 
            this.pnlBankLogo.Controls.Add(this.headerControl1);
            this.pnlBankLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlBankLogo.Name = "pnlBankLogo";
            this.pnlBankLogo.Size = new System.Drawing.Size(800, 150);
            this.pnlBankLogo.TabIndex = 0;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(800, 150);
            this.headerControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnOpenNewAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 320);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Location = new System.Drawing.Point(37, 242);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(188, 39);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOpenNewAccount
            // 
            this.btnOpenNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenNewAccount.Location = new System.Drawing.Point(37, 37);
            this.btnOpenNewAccount.Name = "btnOpenNewAccount";
            this.btnOpenNewAccount.Size = new System.Drawing.Size(188, 39);
            this.btnOpenNewAccount.TabIndex = 0;
            this.btnOpenNewAccount.Text = "Open New Account";
            this.btnOpenNewAccount.UseVisualStyleBackColor = true;
            this.btnOpenNewAccount.Click += new System.EventHandler(this.btnOpenNewAccount_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblWelcome.Location = new System.Drawing.Point(44, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(85, 25);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblLastName.Location = new System.Drawing.Point(200, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "label2";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblFirstName.Location = new System.Drawing.Point(135, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(59, 25);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "label1";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // mainContent
            // 
            this.mainContent.BackColor = System.Drawing.Color.Navy;
            this.mainContent.Controls.Add(this.btnSubmitAccountSelection);
            this.mainContent.Controls.Add(this.lblLastName);
            this.mainContent.Controls.Add(this.lblWelcome);
            this.mainContent.Controls.Add(this.lblFirstName);
            this.mainContent.Controls.Add(this.lblSelectAccount);
            this.mainContent.Controls.Add(this.cbListOfAccount);
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.Location = new System.Drawing.Point(254, 150);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(546, 320);
            this.mainContent.TabIndex = 2;
            // 
            // btnSubmitAccountSelection
            // 
            this.btnSubmitAccountSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.btnSubmitAccountSelection.Location = new System.Drawing.Point(123, 175);
            this.btnSubmitAccountSelection.Name = "btnSubmitAccountSelection";
            this.btnSubmitAccountSelection.Size = new System.Drawing.Size(136, 44);
            this.btnSubmitAccountSelection.TabIndex = 5;
            this.btnSubmitAccountSelection.Text = "Submit";
            this.btnSubmitAccountSelection.UseVisualStyleBackColor = false;
            this.btnSubmitAccountSelection.Click += new System.EventHandler(this.btnSubmitAccountSelection_Click);
            // 
            // lblSelectAccount
            // 
            this.lblSelectAccount.AutoSize = true;
            this.lblSelectAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblSelectAccount.Location = new System.Drawing.Point(22, 77);
            this.lblSelectAccount.Name = "lblSelectAccount";
            this.lblSelectAccount.Size = new System.Drawing.Size(409, 25);
            this.lblSelectAccount.TabIndex = 2;
            this.lblSelectAccount.Text = "Please select your desired account for transactions";
            // 
            // cbListOfAccount
            // 
            this.cbListOfAccount.FormattingEnabled = true;
            this.cbListOfAccount.Location = new System.Drawing.Point(56, 128);
            this.cbListOfAccount.Name = "cbListOfAccount";
            this.cbListOfAccount.Size = new System.Drawing.Size(337, 33);
            this.cbListOfAccount.TabIndex = 1;
            this.cbListOfAccount.SelectedIndexChanged += new System.EventHandler(this.cbListOfAccount_SelectedIndexChanged);
            // 
            // ListOfAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBankLogo);
            this.Name = "ListOfAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfAccounts";
            this.Load += new System.EventHandler(this.ListOfAccounts_Load);
            this.pnlBankLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.mainContent.ResumeLayout(false);
            this.mainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBankLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenNewAccount;
        private System.Windows.Forms.Button btnLogOut;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cbListOfAccount;
        private System.Windows.Forms.Button btnSubmitAccountSelection;
        private System.Windows.Forms.Label lblSelectAccount;
    }
}