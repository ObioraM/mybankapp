
namespace MyBankApp.UI.Controls
{
    partial class AccountBalance
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
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.lblInsertAccountType = new System.Windows.Forms.Label();
            this.lblInsertAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblInsertAccountBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblAccountType.Location = new System.Drawing.Point(90, 75);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(119, 25);
            this.lblAccountType.TabIndex = 0;
            this.lblAccountType.Text = "Account Type";
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblAccountNum.Location = new System.Drawing.Point(90, 123);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(147, 25);
            this.lblAccountNum.TabIndex = 1;
            this.lblAccountNum.Text = "Account Number";
            // 
            // lblInsertAccountType
            // 
            this.lblInsertAccountType.AutoSize = true;
            this.lblInsertAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblInsertAccountType.Location = new System.Drawing.Point(256, 75);
            this.lblInsertAccountType.Name = "lblInsertAccountType";
            this.lblInsertAccountType.Size = new System.Drawing.Size(59, 25);
            this.lblInsertAccountType.TabIndex = 2;
            this.lblInsertAccountType.Text = "label1";
            // 
            // lblInsertAccountNumber
            // 
            this.lblInsertAccountNumber.AutoSize = true;
            this.lblInsertAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblInsertAccountNumber.Location = new System.Drawing.Point(256, 123);
            this.lblInsertAccountNumber.Name = "lblInsertAccountNumber";
            this.lblInsertAccountNumber.Size = new System.Drawing.Size(59, 25);
            this.lblInsertAccountNumber.TabIndex = 3;
            this.lblInsertAccountNumber.Text = "label2";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblAccountBalance.Location = new System.Drawing.Point(90, 176);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(141, 25);
            this.lblAccountBalance.TabIndex = 4;
            this.lblAccountBalance.Text = "Account Balance";
            // 
            // lblInsertAccountBalance
            // 
            this.lblInsertAccountBalance.AutoSize = true;
            this.lblInsertAccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblInsertAccountBalance.Location = new System.Drawing.Point(256, 176);
            this.lblInsertAccountBalance.Name = "lblInsertAccountBalance";
            this.lblInsertAccountBalance.Size = new System.Drawing.Size(59, 25);
            this.lblInsertAccountBalance.TabIndex = 5;
            this.lblInsertAccountBalance.Text = "label1";
            // 
            // AccountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.lblInsertAccountBalance);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.lblInsertAccountNumber);
            this.Controls.Add(this.lblInsertAccountType);
            this.Controls.Add(this.lblAccountNum);
            this.Controls.Add(this.lblAccountType);
            this.Name = "AccountBalance";
            this.Size = new System.Drawing.Size(551, 299);
            this.Load += new System.EventHandler(this.AccountBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.Label lblInsertAccountType;
        private System.Windows.Forms.Label lblInsertAccountNumber;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblInsertAccountBalance;
    }
}
