
namespace MyBankApp.UI.Controls
{
    partial class WithdrawalControl
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
            this.lblWithdrawHeader = new System.Windows.Forms.Label();
            this.lblWithdrawAmount = new System.Windows.Forms.Label();
            this.tbAmountToWithdraw = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnSubmitWithdrawal = new System.Windows.Forms.Button();
            this.lnkLabelBackToDashBoard = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblWithdrawHeader
            // 
            this.lblWithdrawHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWithdrawHeader.AutoSize = true;
            this.lblWithdrawHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblWithdrawHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWithdrawHeader.Location = new System.Drawing.Point(295, 93);
            this.lblWithdrawHeader.Name = "lblWithdrawHeader";
            this.lblWithdrawHeader.Size = new System.Drawing.Size(194, 54);
            this.lblWithdrawHeader.TabIndex = 0;
            this.lblWithdrawHeader.Text = "Withdraw";
            // 
            // lblWithdrawAmount
            // 
            this.lblWithdrawAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWithdrawAmount.AutoSize = true;
            this.lblWithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblWithdrawAmount.Location = new System.Drawing.Point(182, 214);
            this.lblWithdrawAmount.Name = "lblWithdrawAmount";
            this.lblWithdrawAmount.Size = new System.Drawing.Size(176, 25);
            this.lblWithdrawAmount.TabIndex = 1;
            this.lblWithdrawAmount.Text = "Amount to withdraw";
            // 
            // tbAmountToWithdraw
            // 
            this.tbAmountToWithdraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAmountToWithdraw.Location = new System.Drawing.Point(385, 208);
            this.tbAmountToWithdraw.Name = "tbAmountToWithdraw";
            this.tbAmountToWithdraw.Size = new System.Drawing.Size(240, 31);
            this.tbAmountToWithdraw.TabIndex = 2;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblNote.Location = new System.Drawing.Point(307, 272);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(51, 25);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Note";
            // 
            // tbNote
            // 
            this.tbNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNote.Location = new System.Drawing.Point(388, 266);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(175, 31);
            this.tbNote.TabIndex = 4;
            // 
            // btnSubmitWithdrawal
            // 
            this.btnSubmitWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmitWithdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.btnSubmitWithdrawal.Location = new System.Drawing.Point(323, 338);
            this.btnSubmitWithdrawal.Name = "btnSubmitWithdrawal";
            this.btnSubmitWithdrawal.Size = new System.Drawing.Size(112, 34);
            this.btnSubmitWithdrawal.TabIndex = 5;
            this.btnSubmitWithdrawal.Text = "Withdrawal";
            this.btnSubmitWithdrawal.UseVisualStyleBackColor = false;
            this.btnSubmitWithdrawal.Click += new System.EventHandler(this.btnSubmitWithdrawal_Click);
            // 
            // lnkLabelBackToDashBoard
            // 
            this.lnkLabelBackToDashBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkLabelBackToDashBoard.AutoSize = true;
            this.lnkLabelBackToDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lnkLabelBackToDashBoard.Location = new System.Drawing.Point(295, 409);
            this.lnkLabelBackToDashBoard.Name = "lnkLabelBackToDashBoard";
            this.lnkLabelBackToDashBoard.Size = new System.Drawing.Size(178, 25);
            this.lnkLabelBackToDashBoard.TabIndex = 6;
            this.lnkLabelBackToDashBoard.TabStop = true;
            this.lnkLabelBackToDashBoard.Text = "Return to Dashboard";
            // 
            // WithdrawalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.lnkLabelBackToDashBoard);
            this.Controls.Add(this.btnSubmitWithdrawal);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.tbAmountToWithdraw);
            this.Controls.Add(this.lblWithdrawAmount);
            this.Controls.Add(this.lblWithdrawHeader);
            this.Name = "WithdrawalControl";
            this.Size = new System.Drawing.Size(809, 604);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWithdrawHeader;
        private System.Windows.Forms.Label lblWithdrawAmount;
        private System.Windows.Forms.TextBox tbAmountToWithdraw;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnSubmitWithdrawal;
        private System.Windows.Forms.LinkLabel lnkLabelBackToDashBoard;
    }
}
