
namespace MyBankApp.UI.Controls
{
    partial class DepositControlForm
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
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnSubmitDeposit = new System.Windows.Forms.Button();
            this.tbAmountToDeposit = new System.Windows.Forms.TextBox();
            this.lblDepositHeader = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lnkLabelReturnToDashboard = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblDeposit
            // 
            this.lblDeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblDeposit.Location = new System.Drawing.Point(70, 162);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(166, 25);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Amount to Deposit";
            this.lblDeposit.Click += new System.EventHandler(this.lblDeposit_Click);
            // 
            // btnSubmitDeposit
            // 
            this.btnSubmitDeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmitDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.btnSubmitDeposit.Location = new System.Drawing.Point(211, 281);
            this.btnSubmitDeposit.Name = "btnSubmitDeposit";
            this.btnSubmitDeposit.Size = new System.Drawing.Size(139, 39);
            this.btnSubmitDeposit.TabIndex = 2;
            this.btnSubmitDeposit.Text = "Submit";
            this.btnSubmitDeposit.UseVisualStyleBackColor = false;
            this.btnSubmitDeposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAmountToDeposit
            // 
            this.tbAmountToDeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAmountToDeposit.Location = new System.Drawing.Point(281, 159);
            this.tbAmountToDeposit.Name = "tbAmountToDeposit";
            this.tbAmountToDeposit.Size = new System.Drawing.Size(302, 31);
            this.tbAmountToDeposit.TabIndex = 3;
            this.tbAmountToDeposit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDepositHeader
            // 
            this.lblDepositHeader.AutoSize = true;
            this.lblDepositHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblDepositHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepositHeader.Location = new System.Drawing.Point(211, 43);
            this.lblDepositHeader.Name = "lblDepositHeader";
            this.lblDepositHeader.Size = new System.Drawing.Size(156, 46);
            this.lblDepositHeader.TabIndex = 4;
            this.lblDepositHeader.Text = "Deposit";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblNote.Location = new System.Drawing.Point(185, 222);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(51, 25);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Note";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(281, 216);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(190, 31);
            this.tbNote.TabIndex = 6;
            // 
            // lnkLabelReturnToDashboard
            // 
            this.lnkLabelReturnToDashboard.AutoSize = true;
            this.lnkLabelReturnToDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lnkLabelReturnToDashboard.Location = new System.Drawing.Point(189, 344);
            this.lnkLabelReturnToDashboard.Name = "lnkLabelReturnToDashboard";
            this.lnkLabelReturnToDashboard.Size = new System.Drawing.Size(178, 25);
            this.lnkLabelReturnToDashboard.TabIndex = 7;
            this.lnkLabelReturnToDashboard.TabStop = true;
            this.lnkLabelReturnToDashboard.Text = "Return to Dashboard";
            this.lnkLabelReturnToDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabelReturnToDashboard_LinkClicked);
            // 
            // DepositControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.lnkLabelReturnToDashboard);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDepositHeader);
            this.Controls.Add(this.tbAmountToDeposit);
            this.Controls.Add(this.btnSubmitDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Name = "DepositControlForm";
            this.Size = new System.Drawing.Size(660, 458);
            this.Load += new System.EventHandler(this.DepositControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnSubmitDeposit;
        private System.Windows.Forms.TextBox tbAmountToDeposit;
        private System.Windows.Forms.Label lblDepositHeader;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.LinkLabel lnkLabelReturnToDashboard;
    }
}
