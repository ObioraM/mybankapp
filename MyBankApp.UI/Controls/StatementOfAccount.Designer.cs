
namespace MyBankApp.UI.Controls
{
    partial class StatementOfAccount
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
            this.lvstatementofaccount = new System.Windows.Forms.ListView();
            this.TransactionId = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.TransactionType = new System.Windows.Forms.ColumnHeader();
            this.Note = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvstatementofaccount
            // 
            this.lvstatementofaccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransactionId,
            this.Amount,
            this.TransactionType,
            this.Note,
            this.Date});
            this.lvstatementofaccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvstatementofaccount.HideSelection = false;
            this.lvstatementofaccount.Location = new System.Drawing.Point(0, 0);
            this.lvstatementofaccount.Name = "lvstatementofaccount";
            this.lvstatementofaccount.Size = new System.Drawing.Size(761, 476);
            this.lvstatementofaccount.TabIndex = 0;
            this.lvstatementofaccount.UseCompatibleStateImageBehavior = false;
            this.lvstatementofaccount.View = System.Windows.Forms.View.Details;
            this.lvstatementofaccount.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TransactionId
            // 
            this.TransactionId.Text = "TransactionId";
            this.TransactionId.Width = 150;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 150;
            // 
            // TransactionType
            // 
            this.TransactionType.Text = "TransactionType";
            this.TransactionType.Width = 150;
            // 
            // Note
            // 
            this.Note.Text = "Note";
            this.Note.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 150;
            // 
            // StatementOfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvstatementofaccount);
            this.Name = "StatementOfAccount";
            this.Size = new System.Drawing.Size(761, 476);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvstatementofaccount;
        private System.Windows.Forms.ColumnHeader TransactionId;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader TransactionType;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.ColumnHeader Date;
    }
}
