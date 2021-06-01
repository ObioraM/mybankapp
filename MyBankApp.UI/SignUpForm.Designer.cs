
namespace MyBankApp.UI
{
    partial class SignUpForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIntendedPassword = new System.Windows.Forms.Label();
            this.lblIntendedUsername = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.tbInitialDeposit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radBtnCurrentAccount = new System.Windows.Forms.RadioButton();
            this.radBtnSavingsAccount = new System.Windows.Forms.RadioButton();
            this.pnlBankLogo = new System.Windows.Forms.Panel();
            this.headerControl1 = new MyBankApp.UI.Controls.HeaderControl();
            this.btnSubmitSignUp = new System.Windows.Forms.Button();
            this.lnkLabeltoHomePage = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.pnlBankLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblFirstName.Location = new System.Drawing.Point(54, 103);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblLastName.Location = new System.Drawing.Point(54, 155);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 25);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblEmail.Location = new System.Drawing.Point(54, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblIntendedPassword
            // 
            this.lblIntendedPassword.AutoSize = true;
            this.lblIntendedPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblIntendedPassword.Location = new System.Drawing.Point(54, 303);
            this.lblIntendedPassword.Name = "lblIntendedPassword";
            this.lblIntendedPassword.Size = new System.Drawing.Size(163, 25);
            this.lblIntendedPassword.TabIndex = 3;
            this.lblIntendedPassword.Text = "Intended Password";
            // 
            // lblIntendedUsername
            // 
            this.lblIntendedUsername.AutoSize = true;
            this.lblIntendedUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblIntendedUsername.Location = new System.Drawing.Point(54, 251);
            this.lblIntendedUsername.Name = "lblIntendedUsername";
            this.lblIntendedUsername.Size = new System.Drawing.Size(167, 25);
            this.lblIntendedUsername.TabIndex = 4;
            this.lblIntendedUsername.Text = "Intended Username";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(257, 97);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(276, 31);
            this.tbFirstName.TabIndex = 5;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(257, 149);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(276, 31);
            this.tbLastName.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(257, 198);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(276, 31);
            this.tbEmail.TabIndex = 7;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(257, 245);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(276, 31);
            this.tbUserName.TabIndex = 8;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(257, 297);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(276, 31);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblAccountType.Location = new System.Drawing.Point(50, 22);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(119, 25);
            this.lblAccountType.TabIndex = 10;
            this.lblAccountType.Text = "Account Type";
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblInitialDeposit.Location = new System.Drawing.Point(50, 443);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(121, 25);
            this.lblInitialDeposit.TabIndex = 11;
            this.lblInitialDeposit.Text = "Initial Deposit";
            // 
            // tbInitialDeposit
            // 
            this.tbInitialDeposit.Location = new System.Drawing.Point(257, 443);
            this.tbInitialDeposit.Name = "tbInitialDeposit";
            this.tbInitialDeposit.Size = new System.Drawing.Size(150, 31);
            this.tbInitialDeposit.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radBtnCurrentAccount);
            this.panel1.Controls.Add(this.radBtnSavingsAccount);
            this.panel1.Controls.Add(this.lblAccountType);
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 61);
            this.panel1.TabIndex = 14;
            // 
            // radBtnCurrentAccount
            // 
            this.radBtnCurrentAccount.AutoSize = true;
            this.radBtnCurrentAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.radBtnCurrentAccount.Location = new System.Drawing.Point(504, 18);
            this.radBtnCurrentAccount.Name = "radBtnCurrentAccount";
            this.radBtnCurrentAccount.Size = new System.Drawing.Size(165, 29);
            this.radBtnCurrentAccount.TabIndex = 12;
            this.radBtnCurrentAccount.TabStop = true;
            this.radBtnCurrentAccount.Text = "Current Account";
            this.radBtnCurrentAccount.UseVisualStyleBackColor = false;
            // 
            // radBtnSavingsAccount
            // 
            this.radBtnSavingsAccount.AutoSize = true;
            this.radBtnSavingsAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.radBtnSavingsAccount.Location = new System.Drawing.Point(258, 22);
            this.radBtnSavingsAccount.Name = "radBtnSavingsAccount";
            this.radBtnSavingsAccount.Size = new System.Drawing.Size(168, 29);
            this.radBtnSavingsAccount.TabIndex = 11;
            this.radBtnSavingsAccount.TabStop = true;
            this.radBtnSavingsAccount.Text = "Savings Account";
            this.radBtnSavingsAccount.UseVisualStyleBackColor = false;
            // 
            // pnlBankLogo
            // 
            this.pnlBankLogo.Controls.Add(this.headerControl1);
            this.pnlBankLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlBankLogo.Name = "pnlBankLogo";
            this.pnlBankLogo.Size = new System.Drawing.Size(942, 81);
            this.pnlBankLogo.TabIndex = 15;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(942, 81);
            this.headerControl1.TabIndex = 0;
            // 
            // btnSubmitSignUp
            // 
            this.btnSubmitSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.btnSubmitSignUp.Location = new System.Drawing.Point(343, 528);
            this.btnSubmitSignUp.Name = "btnSubmitSignUp";
            this.btnSubmitSignUp.Size = new System.Drawing.Size(112, 34);
            this.btnSubmitSignUp.TabIndex = 16;
            this.btnSubmitSignUp.Text = "Submit";
            this.btnSubmitSignUp.UseVisualStyleBackColor = false;
            this.btnSubmitSignUp.Click += new System.EventHandler(this.btnSubmitSignUp_Click);
            // 
            // lnkLabeltoHomePage
            // 
            this.lnkLabeltoHomePage.AutoSize = true;
            this.lnkLabeltoHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lnkLabeltoHomePage.LinkColor = System.Drawing.Color.Gold;
            this.lnkLabeltoHomePage.Location = new System.Drawing.Point(316, 582);
            this.lnkLabeltoHomePage.Name = "lnkLabeltoHomePage";
            this.lnkLabeltoHomePage.Size = new System.Drawing.Size(167, 25);
            this.lnkLabeltoHomePage.TabIndex = 17;
            this.lnkLabeltoHomePage.TabStop = true;
            this.lnkLabeltoHomePage.Text = "Back to Home Page";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(942, 648);
            this.Controls.Add(this.lnkLabeltoHomePage);
            this.Controls.Add(this.btnSubmitSignUp);
            this.Controls.Add(this.pnlBankLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbInitialDeposit);
            this.Controls.Add(this.lblInitialDeposit);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblIntendedUsername);
            this.Controls.Add(this.lblIntendedPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBankLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIntendedPassword;
        private System.Windows.Forms.Label lblIntendedUsername;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblInitialDeposit;
        private System.Windows.Forms.TextBox tbInitialDeposit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radBtnCurrentAccount;
        private System.Windows.Forms.RadioButton radBtnSavingsAccount;
        private System.Windows.Forms.Panel pnlBankLogo;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.Button btnSubmitSignUp;
        private System.Windows.Forms.LinkLabel lnkLabeltoHomePage;
    }
}