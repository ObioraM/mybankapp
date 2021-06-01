
namespace MyBankApp.UI.Controls
{
    partial class CreateAccountControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectAccountType = new System.Windows.Forms.Label();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.btnSubmitNewAccountDetails = new System.Windows.Forms.Button();
            this.tbInitialDeposit = new System.Windows.Forms.TextBox();
            this.radBtnSavings = new System.Windows.Forms.RadioButton();
            this.radBtnCurrentAccount = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectAccountType
            // 
            this.lblSelectAccountType.AutoSize = true;
            this.lblSelectAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblSelectAccountType.ForeColor = System.Drawing.Color.White;
            this.lblSelectAccountType.Location = new System.Drawing.Point(10, 14);
            this.lblSelectAccountType.Name = "lblSelectAccountType";
            this.lblSelectAccountType.Size = new System.Drawing.Size(119, 25);
            this.lblSelectAccountType.TabIndex = 0;
            this.lblSelectAccountType.Text = "Account Type";
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblInitialDeposit.ForeColor = System.Drawing.Color.White;
            this.lblInitialDeposit.Location = new System.Drawing.Point(10, 24);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(121, 25);
            this.lblInitialDeposit.TabIndex = 1;
            this.lblInitialDeposit.Text = "Initial Deposit";
            // 
            // btnSubmitNewAccountDetails
            // 
            this.btnSubmitNewAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.btnSubmitNewAccountDetails.ForeColor = System.Drawing.Color.White;
            this.btnSubmitNewAccountDetails.Location = new System.Drawing.Point(147, 69);
            this.btnSubmitNewAccountDetails.Name = "btnSubmitNewAccountDetails";
            this.btnSubmitNewAccountDetails.Size = new System.Drawing.Size(153, 49);
            this.btnSubmitNewAccountDetails.TabIndex = 2;
            this.btnSubmitNewAccountDetails.Text = "Submit";
            this.btnSubmitNewAccountDetails.UseVisualStyleBackColor = false;
            this.btnSubmitNewAccountDetails.Click += new System.EventHandler(this.btnSubmitNewAccountDetails_Click);
            // 
            // tbInitialDeposit
            // 
            this.tbInitialDeposit.Location = new System.Drawing.Point(181, 18);
            this.tbInitialDeposit.Name = "tbInitialDeposit";
            this.tbInitialDeposit.Size = new System.Drawing.Size(302, 31);
            this.tbInitialDeposit.TabIndex = 3;
            // 
            // radBtnSavings
            // 
            this.radBtnSavings.AutoSize = true;
            this.radBtnSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.radBtnSavings.ForeColor = System.Drawing.Color.White;
            this.radBtnSavings.Location = new System.Drawing.Point(181, 12);
            this.radBtnSavings.Name = "radBtnSavings";
            this.radBtnSavings.Size = new System.Drawing.Size(168, 29);
            this.radBtnSavings.TabIndex = 4;
            this.radBtnSavings.TabStop = true;
            this.radBtnSavings.Text = "Savings Account";
            this.radBtnSavings.UseVisualStyleBackColor = false;
            // 
            // radBtnCurrentAccount
            // 
            this.radBtnCurrentAccount.AutoSize = true;
            this.radBtnCurrentAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.radBtnCurrentAccount.ForeColor = System.Drawing.Color.White;
            this.radBtnCurrentAccount.Location = new System.Drawing.Point(364, 10);
            this.radBtnCurrentAccount.Name = "radBtnCurrentAccount";
            this.radBtnCurrentAccount.Size = new System.Drawing.Size(165, 29);
            this.radBtnCurrentAccount.TabIndex = 5;
            this.radBtnCurrentAccount.TabStop = true;
            this.radBtnCurrentAccount.Text = "Current Account";
            this.radBtnCurrentAccount.UseVisualStyleBackColor = false;
            this.radBtnCurrentAccount.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSelectAccountType);
            this.panel1.Controls.Add(this.radBtnCurrentAccount);
            this.panel1.Controls.Add(this.radBtnSavings);
            this.panel1.Location = new System.Drawing.Point(93, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 51);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblInitialDeposit);
            this.panel2.Controls.Add(this.tbInitialDeposit);
            this.panel2.Controls.Add(this.btnSubmitNewAccountDetails);
            this.panel2.Location = new System.Drawing.Point(93, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 118);
            this.panel2.TabIndex = 7;
            // 
            // CreateAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateAccountControl";
            this.Size = new System.Drawing.Size(720, 374);
            this.Load += new System.EventHandler(this.CreateAccountControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAccountType;
        private System.Windows.Forms.Label lblInitialDeposit;
        private System.Windows.Forms.Button btnSubmitNewAccountDetails;
        private System.Windows.Forms.TextBox tbInitialDeposit;
        private System.Windows.Forms.RadioButton radBtnSavings;
        private System.Windows.Forms.RadioButton radBtnCurrentAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
