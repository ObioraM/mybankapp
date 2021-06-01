
namespace MyBankApp.UI.Controls
{
    partial class TransferFundForm
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
            this.lblTransferHeader = new System.Windows.Forms.Label();
            this.lblReceiversAccountNumber = new System.Windows.Forms.Label();
            this.lblTransferAmount = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbReceiverAccountNumber = new System.Windows.Forms.TextBox();
            this.tbAmountToTransfer = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lnkLabelReturnToDashBoard = new System.Windows.Forms.LinkLabel();
            this.btnTransferSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransferHeader
            // 
            this.lblTransferHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTransferHeader.AutoSize = true;
            this.lblTransferHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblTransferHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransferHeader.Location = new System.Drawing.Point(332, 51);
            this.lblTransferHeader.Name = "lblTransferHeader";
            this.lblTransferHeader.Size = new System.Drawing.Size(121, 41);
            this.lblTransferHeader.TabIndex = 0;
            this.lblTransferHeader.Text = "Transfer";
            // 
            // lblReceiversAccountNumber
            // 
            this.lblReceiversAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReceiversAccountNumber.AutoSize = true;
            this.lblReceiversAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblReceiversAccountNumber.Location = new System.Drawing.Point(134, 119);
            this.lblReceiversAccountNumber.Name = "lblReceiversAccountNumber";
            this.lblReceiversAccountNumber.Size = new System.Drawing.Size(238, 25);
            this.lblReceiversAccountNumber.TabIndex = 1;
            this.lblReceiversAccountNumber.Text = "Account Number of Receiver";
            // 
            // lblTransferAmount
            // 
            this.lblTransferAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTransferAmount.AutoSize = true;
            this.lblTransferAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblTransferAmount.Location = new System.Drawing.Point(207, 180);
            this.lblTransferAmount.Name = "lblTransferAmount";
            this.lblTransferAmount.Size = new System.Drawing.Size(165, 25);
            this.lblTransferAmount.TabIndex = 2;
            this.lblTransferAmount.Text = "Amount to Transfer";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblNote.Location = new System.Drawing.Point(321, 231);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(51, 25);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Note";
            // 
            // tbReceiverAccountNumber
            // 
            this.tbReceiverAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbReceiverAccountNumber.Location = new System.Drawing.Point(419, 119);
            this.tbReceiverAccountNumber.Name = "tbReceiverAccountNumber";
            this.tbReceiverAccountNumber.Size = new System.Drawing.Size(145, 31);
            this.tbReceiverAccountNumber.TabIndex = 4;
            // 
            // tbAmountToTransfer
            // 
            this.tbAmountToTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAmountToTransfer.Location = new System.Drawing.Point(419, 174);
            this.tbAmountToTransfer.Name = "tbAmountToTransfer";
            this.tbAmountToTransfer.Size = new System.Drawing.Size(145, 31);
            this.tbAmountToTransfer.TabIndex = 5;
            // 
            // tbNote
            // 
            this.tbNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNote.Location = new System.Drawing.Point(419, 225);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(145, 31);
            this.tbNote.TabIndex = 6;
            // 
            // lnkLabelReturnToDashBoard
            // 
            this.lnkLabelReturnToDashBoard.AutoSize = true;
            this.lnkLabelReturnToDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lnkLabelReturnToDashBoard.Location = new System.Drawing.Point(307, 389);
            this.lnkLabelReturnToDashBoard.Name = "lnkLabelReturnToDashBoard";
            this.lnkLabelReturnToDashBoard.Size = new System.Drawing.Size(178, 25);
            this.lnkLabelReturnToDashBoard.TabIndex = 7;
            this.lnkLabelReturnToDashBoard.TabStop = true;
            this.lnkLabelReturnToDashBoard.Text = "Return To DashBoard";
            // 
            // btnTransferSubmit
            // 
            this.btnTransferSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.btnTransferSubmit.Location = new System.Drawing.Point(338, 307);
            this.btnTransferSubmit.Name = "btnTransferSubmit";
            this.btnTransferSubmit.Size = new System.Drawing.Size(115, 38);
            this.btnTransferSubmit.TabIndex = 8;
            this.btnTransferSubmit.Text = "Submit";
            this.btnTransferSubmit.UseVisualStyleBackColor = false;
            this.btnTransferSubmit.Click += new System.EventHandler(this.btnTransferSubmit_Click);
            // 
            // TransferFundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.btnTransferSubmit);
            this.Controls.Add(this.lnkLabelReturnToDashBoard);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbAmountToTransfer);
            this.Controls.Add(this.tbReceiverAccountNumber);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblTransferAmount);
            this.Controls.Add(this.lblReceiversAccountNumber);
            this.Controls.Add(this.lblTransferHeader);
            this.Name = "TransferFundForm";
            this.Size = new System.Drawing.Size(699, 544);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransferHeader;
        private System.Windows.Forms.Label lblReceiversAccountNumber;
        private System.Windows.Forms.Label lblTransferAmount;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tbReceiverAccountNumber;
        private System.Windows.Forms.TextBox tbAmountToTransfer;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.LinkLabel lnkLabelReturnToDashBoard;
        private System.Windows.Forms.Button btnTransferSubmit;
    }
}
